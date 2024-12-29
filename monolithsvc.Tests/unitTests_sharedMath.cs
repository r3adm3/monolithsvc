using Microsoft.VisualStudio.TestTools.UnitTesting;
using monolithsvc.Models;

namespace monolithsvc.Tests
{
    [TestClass]
    public class UnitTests_SharedMaths
    {
        //shared arrange 

        [TestMethod]
        public void CanInstantiateSharedMaths()
        {
            //arrange
            SharedMath myObj = new SharedMath();
 
            //act
          

            //assert
            Assert.IsNotNull(myObj);

        }

        [TestMethod]
        public void addingTwoNumbersReturnsExpectedResult()
        {
            //arrange
            SharedMath myObj = new();
 
            //act
            int myTest = SharedMath.AddTwoNumbers(1,2);

            //assert
            Assert.AreEqual(3, myTest);
        }

        [TestMethod]
        public void MinusTwoNumbersReturnsExpectedResult()
        {
            //arrange
            SharedMath myObj = new();
 
            //act
            int myTest = SharedMath.MinusTwoNumbers(2,1);

            //assert
            Assert.AreEqual(1, myTest);

        }

        [TestMethod]
        public void MultiplyTwoNumbersReturnsExpectedResult()
        {
            //arrange
            SharedMath myObj = new();
 
            //act
            int myTest = SharedMath.MultiplyTwoNumbers(2,1);

            //assert
            Assert.AreEqual(2, myTest);

        }

        [TestMethod]
        public void PowerTwoNumbersReturnsExpectedResult()
        {
            SharedMath myObj = new();

            double myTest = SharedMath.PowerTwoNumbers(2,3);

            Assert.AreEqual(8, myTest);
        }

        [TestMethod]
        public void DotnetverReturns()
        {
            SharedMath myObj = new SharedMath();

            string myTest = myObj.Dotnetver;

            Assert.AreEqual(".NET   9.0.0", myTest);
        }


        [TestMethod]
        public void HostnameReturns()
        {
            SharedMath myObj = new SharedMath();

            string myTest = myObj.Hostname;

            Assert.IsNotNull(myTest);
            
        }
    }
}
