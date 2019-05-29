using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class unitTests_homeController
    {
        
        public static IConfiguration _configuration;

        [TestMethod]
        public void HomeControllerCanInstantiate()
        {
            var controller = new HomeController(_configuration);

            var result = controller.About();

            Assert.IsNotNull(result);

        }

    }
}
