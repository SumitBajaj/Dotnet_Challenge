using System;
using Dotcom_Challenge.Controllers;
using Dotcom_Challenge_BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dotnet_Challenge_Tests
{
    [TestClass]
    public class ConversionControllerTest
    {
        [TestMethod]
        public void ShouldReturnWords()
        {
            string input_value = "578";
            IConversion _conversion = new Conversion();
            string result = _conversion.ConversionToWords(input_value);
            Assert.AreEqual(result, "Five Hundred Seventy Eight");
        }
    }
}
