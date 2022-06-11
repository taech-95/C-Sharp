using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConventer inputConventer = new InputConventer();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.WriteLine("Give first number");
                double first_number = inputConventer.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Give second number");
                double second_number = inputConventer.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Choose operation");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, first_number, second_number);
                Console.WriteLine(result);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    public class AddOrSubtract
    {
        public static int Calculate(int firstNumber, int secondNumber)
        {
            int result = 0;
            if (firstNumber <= secondNumber)
            {
                result = secondNumber + firstNumber;
            }
            else
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }
    }
}
