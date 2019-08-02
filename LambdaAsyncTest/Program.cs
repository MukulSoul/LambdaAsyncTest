using System;
using Amazon.Lambda.AspNetCoreServer;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace LambdaAsyncTest
{
    public class Program
    {

        public  static string ContainerId = Guid.NewGuid().ToString();

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }

    public class LambdaEntryPoint : APIGatewayProxyFunction<Startup>
    {
        
    }
}
