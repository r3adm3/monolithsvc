using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class unitTests_addController
    {
        [TestMethod]
        public void addControllerTwoPlusOneEqualsThree()
        {
            var controller = new addController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;
            if (actualResult != null){
                Assert.AreEqual(3, actualResult.mathresult);
            } else {
                Assert.Fail();
            }

        }
        
    }
}
