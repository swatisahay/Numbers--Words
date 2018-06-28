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
      Assert.AreEqual("fifty four", integer.calculate(54));
    }
  }
}
