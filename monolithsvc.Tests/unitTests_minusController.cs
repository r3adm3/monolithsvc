using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using monolithsvc.Controllers;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Tests
{
    [TestClass]
    public class unitTests_minusController
    {
        [TestMethod]
        public void addControllerTwoTakeAwayOneEqualsOne()
        {
            var controller = new minusController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;

            Assert.AreEqual(1, actualResult.mathresult);

        }

    }
}
