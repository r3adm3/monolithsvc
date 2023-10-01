using Microsoft.VisualStudio.TestTools.UnitTesting;
using monolithsvc.Models;

namespace monolithsvc.Tests
{
    [TestClass]
    public class unitTests_SharedMaths
    {
        //shared arrange 

        [TestMethod]
        public void CanInstantiateSharedMaths()
        {
            //arrange
            sharedMath myObj = new sharedMath();
 
            //act
          

            //assert
            Assert.IsNotNull(myObj);

        }

        [TestMethod]
        public void addingTwoNumbersReturnsExpectedResult()
        {
            //arrange
            sharedMath myObj = new sharedMath();
 
            //act
            int myTest = myObj.addTwoNumbers(1,2);

            //assert
            Assert.AreEqual(myTest, 3);
        }

        [TestMethod]
        public void minusTwoNumbersReturnsExpectedResult()
        {
            //arrange
            sharedMath myObj = new sharedMath();
 
            //act
            int myTest = myObj.minusTwoNumbers(2,1);

            //assert
            Assert.AreEqual(myTest, 1);

        }

        [TestMethod]
        public void multiplyTwoNumbersReturnsExpectedResult()
        {
            //arrange
            sharedMath myObj = new sharedMath();
 
            //act
            int myTest = myObj.multiplyTwoNumbers(2,1);

            //assert
            Assert.AreEqual(myTest, 2);

        }

        [TestMethod]
        public void powerTwoNumbersReturnsExpectedResult()
        {
            sharedMath myObj = new sharedMath();

            double myTest = myObj.powerTwoNumbers(2,3);

            Assert.AreEqual(myTest, 8);
        }
    } 
}
