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
        
        public static IConfiguration? _configuration;

        [TestMethod]
        public void HomeControllerCanInstantiateIndex()
        {
            
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsNotNull(result);

        }

                [TestMethod]
        public void HomeControllerCanInstantiatePrivacy()
        {
            var controller = new HomeController();

            var result = controller.Privacy();

            Assert.IsNotNull(result);

        }

    }
}
