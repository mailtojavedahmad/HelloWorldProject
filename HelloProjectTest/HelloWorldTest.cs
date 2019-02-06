using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloProjectTest
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void Test_DivideMethod()
        {
            // Arrange
            int expeted = 4;
            int numerator = 20;
            int denominator = 5;

            //Act
           int actual = HelloWorldProject.Program.DivideMethod(numerator, denominator);

            //Assert
            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void Test_DivideMethodWithNegative()
        {
            // Arrange
            int expeted = 2;
            int numerator = 10;
            int denominator = 5;

            //Act
            int actual = HelloWorldProject.Program.DivideMethod(numerator, denominator);

            //Assert
            Assert.AreEqual(expeted, actual);
        }
    }
}
