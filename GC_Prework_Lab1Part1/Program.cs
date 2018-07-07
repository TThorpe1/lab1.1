
using System;

namespace GC_Prework_Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var num1 = 0;
                var num2 = 0;

                {
                    Console.WriteLine("Let's check for equality");
                    //Gather information from user
                    Console.WriteLine("Please enter the 1st number");
                    var firstNumber = Console.ReadLine();

                    Console.WriteLine("Please enter the 2nd number of equal length");

                    var secondNumber = Console.ReadLine();
                    
                    //Compare lengths of user input
                    if (firstNumber.Length != secondNumber.Length)
                    {
                        Console.WriteLine("the lengths are not equal");

                    }
                    //Convert numbers
                    if (!int.TryParse(firstNumber, out num1))
                    {
                        Console.WriteLine("Your 1st number is not valid, Please try again");

                    }
                    if (!int.TryParse(secondNumber, out num2))
                    {
                        Console.WriteLine("Your 2nd number is not valid, Please try all over again");

                    }
                }

                var totalNumber = num1 + num2;
                var totalNumberString = totalNumber.ToString();
                var validate = totalNumberString[0];

                //Equality check
                var isEqual = true;
                for (int i = 0; i < totalNumber.ToString().Length; i++)
                {
                    if (totalNumberString[i] != validate)
                    {
                        isEqual = false;

                    }
                }
                var result = isEqual ? "True. The sums of the corresponding place values are equal" : "False. The sums of the corresponding place values are not equal";
                Console.WriteLine(result);

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();

            }
        }
    }
}



