using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class unitTests_multiplyController
    {
        [TestMethod]
        public void multiplyControllerTwoMultiplyOneEqualsTwo()
        {
            var controller = new multiplyController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;

            Assert.AreEqual(2, actualResult.mathresult);

        }

    }
}
