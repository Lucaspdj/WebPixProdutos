using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebPixProdutos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BuildWebHostAsync(args).GetAwaiter().GetResult().Run();
        }

        public static async Task<IWebHost> BuildWebHostAsync(string[] args)
        {
            var url = await AuxNotStatic.GetInfoMotorAux("Produto", 1);
            return WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>()
                 .UseUrls(url.Url)
                 .Build();
        }
    }
}
