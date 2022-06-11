using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.TestUnit
{
    [TestClass]
    public class CalculatorEngineTest
    {

        private readonly Simple_Calculator.CalculatorEngine calculatorEngine = new Simple_Calculator.CalculatorEngine();
        
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultforNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }
    }
}
