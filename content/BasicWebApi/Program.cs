using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BasicWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
//#if (IncludeApplicationInsights)                
                .UseApplicationInsights()
//#endif
                .Build();

            host.Run();
        }
    }
}
