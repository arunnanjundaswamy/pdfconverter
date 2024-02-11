using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace PDFConverterConsole.Converters
{
    public class LibreOfficePDFConverter
    {
        private readonly ILogger<LibreOfficePDFConverter> _logger;
        private readonly IConfiguration _configuration;

        public LibreOfficePDFConverter(ILogger<LibreOfficePDFConverter> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            
        }
        public void ConvertToPDF(string inputDir, string outputDir, string fileName = null, string fileNameWithPath = null)
        {
            if (string.IsNullOrEmpty(fileNameWithPath) && string.IsNullOrEmpty(fileName))
            {
                _logger.LogError("Should have either fileNameWithPath or fileName");
                return;
            }

            if (string.IsNullOrEmpty(fileNameWithPath))
                fileNameWithPath = $"{inputDir}/{fileName}";

            var libreOfficePath = _configuration["ApplicationConfig:LibreOfficePath"];

            // Create LibreOfficeWriter CLI process
            var commandArgs = new List<string>
            {
                "--convert-to", //a flag that will be followed by the file type we want to convert to
                //"pdf:writer_pdf_Export", // the [output file type]:[OutputFilterName] we are requesting the output to be; more details are here (https://help.libreoffice.org/latest/en-US/text/shared/guide/convertfilters.html)
                //"pdf:writer_pdf_Export:{\"TiledWatermark\":{\"type\":\"string\",\"value\":\"draft\"},\"SinglePageSheets\":{\"type\":\"boolean\",\"value\":\"true\"}}",
                "pdf:impress_pdf_Export:{\"PageLayout\":{\"type\":\"long\",\"value\":\"1\"},\"SinglePageSheets\":{\"type\":\"boolean\",\"value\":\"true\"}}",
                //"C:\\Users\\zachary\\Downloads\\Letter.docx", // input file
                //"C:\\Interneuron\\Assignments\\Feats\\PDS-2\\SCAL_Evidences\\V1.1\\Submitted_Stage1_01022024\\ErrorsAndWarnings.xlsx",
                fileNameWithPath,
                "--norestore", // disables restart and file recovery after a system crash
                "--headless", // allows using the application without user interface
                "--outdir", // a flag that will be followed by the output directory where we want our new pdf file to be created
                //"C:\\Users\\zachary\\Downloads" // output directory
                //"C:\\Interneuron\\",
                outputDir
                //"--infilter",
                //"TiledWatermark:hhhhhhhhh"
            };

            //C:\Interneuron\POCs\LibreOfficePortable_24.2.0_MultilingualAll.paf.exe
            // The path to LibreOfficeWriterPortable.exe
            //ProcessStartInfo processStartInfo = new ProcessStartInfo("C:\\Users\\zachary\\Downloads\\LibreOfficePortablePrevious\\LibreOfficeWriterPortable.exe");
            ProcessStartInfo processStartInfo = new ProcessStartInfo($"{libreOfficePath}\\LibreOfficeWriterPortable.exe");
            foreach (string arg in commandArgs)
                processStartInfo.ArgumentList.Add(arg);

            Process process = new Process
            {
                StartInfo = processStartInfo
            };

            // Only 1 instance of LibreOfficeWriter can be running at a given time
            //not sure why
            
            Process[] existingProcesses = Process.GetProcessesByName("soffice");
            while (existingProcesses.Length > 0)
            {
                foreach(var p in existingProcesses)
                {
                    try
                    {
                        p.Close();
                        p.Dispose();
                    }
                    catch { }
                }
                    
                Thread.Sleep(1000);
                existingProcesses = Process.GetProcessesByName("soffice");
            }
            

            try
            {
                // Start the process
                process.Start();
                process.WaitForExit();

                // Check for failed exit code.
                if (process.ExitCode != 0)
                    throw new Exception("Failed to convert file");
                else
                {
                    int totalChecks = 10;
                    int currentCheck = 1;

                    string originalFileName = Path.GetFileNameWithoutExtension(commandArgs[2]);
                    string newFilePath = Path.Combine(commandArgs[6], $"{originalFileName}.pdf");

                    while (currentCheck <= totalChecks)
                    {
                        if (File.Exists(newFilePath))
                        {
                            // File conversion was successful

                            break;
                        }

                        Thread.Sleep(500); // LibreOffice doesn't immediately create PDF output once the command is run
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception converting to pdf in libreoffice converter", ex);
            }
            
        }
    }
}
