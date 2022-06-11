using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.TestUnit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly Simple_Calculator.InputConventer inputConventer = new Simple_Calculator.InputConventer();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = inputConventer.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "asdsadsadsadsa";
            double convertedNumber = inputConventer.ConvertInputToNumeric(inputNumber);
        }
    }
}
