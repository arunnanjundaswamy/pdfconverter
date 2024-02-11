using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PDFConverterConsole.Converters
{
    public class ExcelConverter
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<WordConverter> _logger;
        private readonly LibreOfficePDFConverter _pdfConverter;

        public ExcelConverter(IConfiguration configuration, ILogger<WordConverter> logger, LibreOfficePDFConverter pdfConverter)
        {
            _configuration = configuration;
            _logger = logger;
            _pdfConverter = pdfConverter;
        }

        public void ConvertToPDF()
        {
            var filesToConvert = GetFileNames();
            if (filesToConvert == null || filesToConvert.Length == 0)
            {
                _logger.LogInformation($"No excel files to convert.");
                return;
            }
            var inputDir = _configuration["ApplicationConfig:InputDir"];
            var outputDir = _configuration["ApplicationConfig:OutputDir"];

            Parallel.ForEach(filesToConvert, new ParallelOptions { MaxDegreeOfParallelism = 1 }, file =>
            {
                _logger.LogInformation($"Converting file to pdf started: {file}");
                _pdfConverter.ConvertToPDF(inputDir, outputDir, fileNameWithPath: file);
                _logger.LogInformation($"Converting file to pdf completed: {file}");
            });
        }

        private string[] GetFileNames()
        {
            try
            {
                var inputDir = _configuration["ApplicationConfig:InputDir"];

                string[] files = Directory.GetFiles(inputDir, "*.xls?", SearchOption.AllDirectories);

                return files;

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting file names in excel file converter", ex);
            }
            return null;
        }
    }
}
