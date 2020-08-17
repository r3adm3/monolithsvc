using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

//commit to force a change (x2 4/2)
namespace monolithsvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            //comments are cool man!
=======
            //test commit
>>>>>>> 0a364816ceaaff4bb6c47e14a61955714fdeda2a
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
