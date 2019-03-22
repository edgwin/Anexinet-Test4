using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test4.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GettingAnagramOK()
        {
            //Arrange
            var firstString = "Regios";
            var secondString = "Sergio";
            //Act
            var response = Program.IsAnagram(firstString, secondString);
            //Assert
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void GettingAnagramNotOK()
        {
            //Arrange
            var firstString = "Charly";
            var secondString = "Sergio";
            //Act
            var response = Program.IsAnagram(firstString, secondString);
            //Assert
            Assert.IsFalse(response);
        }
    }
}
