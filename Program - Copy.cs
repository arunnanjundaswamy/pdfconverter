//using Gotenberg.Sharp.API.Client.Domain.Builders.Faceted;
//using Gotenberg.Sharp.API.Client.Domain.Builders;
//using Gotenberg.Sharp.API.Client;
//using System.Diagnostics;
//using static System.Net.Mime.MediaTypeNames;
//using System;

//namespace PDFConverterConsole
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");

//            //using (var converter = new Converter())
//            //{
//            //    //converter.Convert(< inputfile >, < outputfile >);
//            //}

//            ConvertToPDF();

//            //Task.Run(async () => await DoConversion("C:/Interneuron/Assignments/Feats/PDS-2/SCAL_Evidences/V1.1/Submitted_Stage1_01022024"));

//            Console.ReadLine();
//        }

//        private static void ConvertToPDF()
//        {
//            // Create LibreOfficeWriter CLI process
//            var commandArgs = new List<string>
//            {
//                "--convert-to", //a flag that will be followed by the file type we want to convert to
//                //"pdf:writer_pdf_Export", // the [output file type]:[OutputFilterName] we are requesting the output to be; more details are here (https://help.libreoffice.org/latest/en-US/text/shared/guide/convertfilters.html)
//                //"pdf:writer_pdf_Export:{\"TiledWatermark\":{\"type\":\"string\",\"value\":\"draft\"},\"SinglePageSheets\":{\"type\":\"boolean\",\"value\":\"true\"}}",
//                "pdf:impress_pdf_Export:{\"PageLayout\":{\"type\":\"long\",\"value\":\"1\"},\"SinglePageSheets\":{\"type\":\"boolean\",\"value\":\"true\"}}",
//                //"C:\\Users\\zachary\\Downloads\\Letter.docx", // input file
//                "C:\\Interneuron\\Assignments\\Feats\\PDS-2\\SCAL_Evidences\\V1.1\\Submitted_Stage1_01022024\\ErrorsAndWarnings.xlsx",
//                "--norestore", // disables restart and file recovery after a system crash
//                "--headless", // allows using the application without user interface
//                "--outdir", // a flag that will be followed by the output directory where we want our new pdf file to be created
//                //"C:\\Users\\zachary\\Downloads" // output directory
//                "C:\\Interneuron\\",
//                //"--infilter",
//                //"TiledWatermark:hhhhhhhhh"
//            };

//            //C:\Interneuron\POCs\LibreOfficePortable_24.2.0_MultilingualAll.paf.exe
//            // The path to LibreOfficeWriterPortable.exe
//            //ProcessStartInfo processStartInfo = new ProcessStartInfo("C:\\Users\\zachary\\Downloads\\LibreOfficePortablePrevious\\LibreOfficeWriterPortable.exe");
//            ProcessStartInfo processStartInfo = new ProcessStartInfo("C:\\Interneuron\\POCs\\LibreOfficePortable\\LibreOfficeWriterPortable.exe");
//            foreach (string arg in commandArgs)
//                processStartInfo.ArgumentList.Add(arg);

//            Process process = new Process
//            {
//                StartInfo = processStartInfo
//            };

//            // Only 1 instance of LibreOfficeWriter can be running at a given time
//            Process[] existingProcesses = Process.GetProcessesByName("soffice");
//            while (existingProcesses.Length > 0)
//            {
//                Thread.Sleep(1000);
//                existingProcesses = Process.GetProcessesByName("soffice");
//            }

//            // Start the process
//            process.Start();
//            process.WaitForExit();

//            // Check for failed exit code.
//            if (process.ExitCode != 0)
//                throw new Exception("Failed to convert file");
//            else
//            {
//                int totalChecks = 10;
//                int currentCheck = 1;

//                string originalFileName = Path.GetFileNameWithoutExtension(commandArgs[2]);
//                string newFilePath = Path.Combine(commandArgs[6], $"{originalFileName}.pdf");

//                while (currentCheck <= totalChecks)
//                {
//                    if (File.Exists(newFilePath))
//                    {
//                        // File conversion was successful

//                        break;
//                    }

//                    Thread.Sleep(500); // LibreOffice doesn't immediately create PDF output once the command is run
//                }
//            }
//        }
    


//        async static Task<string> DoConversion(string destinationPath)
//        {
//            try
//            {
//                var sharpClient = new GotenbergSharpClient("http://localhost:3000");

//                var items = Directory.GetFiles(destinationPath, "*.pdf", SearchOption.TopDirectoryOnly)
//                    .Select(p => new { Info = new FileInfo(p), Path = p })
//                    .OrderBy(item => item.Info.CreationTime)
//                    .Take(2);

//                var toConvert = items.Select(item => KeyValuePair.Create(item.Info.Name, File.ReadAllBytes(item.Path)));

//                //new DocumentBuilder("").m

//                var builder = new PdfConversionBuilder()
//                   .WithPdfs(b => b.AddItems(toConvert))
//                   .SetFormat(PdfFormats.A3b);

//                var request = builder.Build();

//                var response = await sharpClient.ConvertPdfDocumentsAsync(request);

//                //If you send one in -- the result is pdf.
//                var extension = items.Count() > 1 ? "zip" : "pdf";
//                var outPath = @$"{destinationPath}\GotenbergConvertResult.{extension}";

//                using (var destinationStream = File.Create(outPath))
//                {
//                    await response.CopyToAsync(destinationStream, default(CancellationToken));
//                }

//                return outPath;
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//            }
//            return null;

//        }
//    }
//}