using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class UnitTests_multiplyController
    {
        [TestMethod]
        public void multiplyControllerTwoMultiplyOneEqualsTwo()
        {
            var controller = new MultiplyController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;

             if (actualResult != null){
                Assert.AreEqual(2, actualResult.Mathresult);
            } else {
                Assert.Fail();
            }

        }

    }
}
