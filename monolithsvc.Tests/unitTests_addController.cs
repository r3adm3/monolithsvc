using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class UnitTests_addController
    {
        [TestMethod]
        public void AddControllerTwoPlusOneEqualsThree()
        {
            var controller = new AddController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;
            if (actualResult != null){
                Assert.AreEqual(3, actualResult.Mathresult);
            } else {
                Assert.Fail();
            }

        }
        
    }
}
