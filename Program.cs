using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using PDFConverterConsole.Converters;

namespace PDFConverterConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = BuildConfig();
            //Add Services
            var serviceProvider = AddServices(config);

            var logger = serviceProvider?.GetService<ILoggerFactory>()?.CreateLogger<Program>();
            logger?.LogDebug("Starting application");

            var wordConverter = serviceProvider?.GetService<WordConverter>();
            wordConverter?.ConvertToPDF();

            var excelConverter = serviceProvider?.GetService<ExcelConverter>();
            excelConverter?.ConvertToPDF();

            var pptConverter = serviceProvider?.GetService<PowerPointConverter>();
            pptConverter?.ConvertToPDF();

            Console.ReadLine();
        }

        static IConfiguration BuildConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            return config;
        }

        private static ServiceProvider AddServices(IConfiguration configuration)
        {
            //setup  DI
            var serviceProvider = new ServiceCollection()
                .AddLogging(o =>{ 
                    o.ClearProviders();
                    o.AddConsole();
                })
                .AddSingleton<IConfiguration>(configuration)
                .AddSingleton<LibreOfficePDFConverter>()
                .AddSingleton<WordConverter>()
                .AddSingleton<ExcelConverter>()
                .AddSingleton<PowerPointConverter>()
                //.AddSingleton<IWord, Word>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}