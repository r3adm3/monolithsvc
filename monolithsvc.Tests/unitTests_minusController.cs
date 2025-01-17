using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class UnitTests_minusController
    {
        [TestMethod]
        public void addControllerTwoTakeAwayOneEqualsOne()
        {
            var controller = new MinusController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;

           if (actualResult != null){
                Assert.AreEqual(1, actualResult.Mathresult);
            } else {
                Assert.Fail();
            }
            
        }

    }
}
