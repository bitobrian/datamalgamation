using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace TheManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureLogging(loggingConfig =>
                {
                    //loggingConfig.ClearProviders();
                })
                .UseSerilog((hostingContext, loggingConfig) =>
                {
                    loggingConfig.ReadFrom.Configuration(hostingContext.Configuration);
                });
    }
}
