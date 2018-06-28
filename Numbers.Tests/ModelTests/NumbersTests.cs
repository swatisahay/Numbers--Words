using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;
using System;
using System.Collections.Generic;

namespace conversion.Tests
{
  [TestClass]
    public class NumbersTest
    {
    [TestMethod]
    public void NumberToWord_WordCalculate_GetString()
    {
      //Arrange
       Conversion integer = new Conversion();

      //Act

      //Assert
      Assert.AreEqual("four", integer.calculate(4));
    }
    [TestMethod]
    public void NumberToWord_WordCalculateTens_GetString()
    {
      //Arrange
       Conversion integer = new Conversion();

      //Act

      //Assert
      Assert.AreEqual("fifty four", integer.calculate(54));
    }
    [TestMethod]
    public void NumberToWord_WordCalculateTeens_GetString()
    {
      //Arrange
       Conversion integer = new Conversion();

      //Act

      //Assert
      Assert.AreEqual("twelve", integer.teenCheck(12));
    }
    [TestMethod]
    public void NumberToWord_WordCalculateTeensAgain_GetString()
    {
      //Arrange
       Conversion integer = new Conversion();

      //Act

      //Assert
      Assert.AreEqual("twelve", integer.calculate(12));
    }
    [TestMethod]
    public void NumberToWord_WordCalculateHundreds_GetString()
    {
      //Arrange
       Conversion integer = new Conversion();

      //Act

      //Assert
      Assert.AreEqual("eight hundred twelve", integer.calculate(812));
    }
  }
}
