using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Data.USER_MANUAL);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine(Data.DELIMITER);
                Console.WriteLine("MENU");
                Console.WriteLine("Mode 1: Get result applying compound interest to start value");
                Console.WriteLine("Mode 2: Get compound interest having start and end values");
                Console.WriteLine("Exit");
                Console.WriteLine(Data.DELIMITER);
                

                byte userInput = 0;
                while (userInput < 1 || userInput > 3)
                {
                    Console.WriteLine("Select mode=>");
                    string input = Console.ReadLine();
                    Byte.TryParse(input, out userInput);
                }

                Console.WriteLine(Data.DELIMITER);

                switch (userInput)
                {
                    case 1:
                        ModeOne();
                        break;
                    case 2:
                        ModeTwo();
                        break;
                    case 3:
                        isRunning = false;
                        break;
                    default:
                        break;
                }

                Console.WriteLine(Data.DELIMITER);
            }
        }

        private static void ModeOne()
        {
            double startValue;
            double interest;
            int periods;
            string userInput;
            do
            {
                Console.WriteLine("Enter start value");
                userInput = Console.ReadLine();
            }while(!double.TryParse(userInput, out startValue));

            do
            {
                Console.WriteLine("Enter interest");
                userInput = Console.ReadLine();
            }while(!double.TryParse(userInput, out interest));

            do
            {
                Console.WriteLine("Enter number of periods");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out periods));

            Console.WriteLine(Calculator.GetEndValue(startValue, interest, periods));
        }

        private static void ModeTwo()
        {
            double startValue;
            double endValue;
            int periods;
            string userInput;
            do
            {
                Console.WriteLine("Enter start value");
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out startValue));

            do
            {
                Console.WriteLine("Enter end value");
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out endValue));

            do
            {
                Console.WriteLine("Enter number of periods");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out periods));

            Console.WriteLine(Calculator.GetCompoundInterest(startValue, endValue, periods));
        }
    }
}
