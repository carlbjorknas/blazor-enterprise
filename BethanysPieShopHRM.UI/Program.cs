using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BethanysPieShopHRM.UI
{
    // When manually entering an url that has a parameter I lose the styling and get the error below in the console
    // GET https://localhost:44329/employeedetail/css/site.css net::ERR_ABORTED 404
    // It's looking for site.css at wrong url?

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
                });
    }
}
