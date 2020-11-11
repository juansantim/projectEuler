using System;
using System.Collections.Generic;
using System.Text;

namespace projectEuler.excercise2
{
    public class Excercise2
    {
        public static void Run() 
        {
            int sum = printFibonacci(4000000);

            Console.WriteLine($"The sum is {sum}");
        }

        static int printFibonacci(int maxNumber) 
        {
            int penultimate = 1;
            int latest = 1;

            int i = 1;

            var currentNumber = 0;
            int sum = 0;

            while (currentNumber <= maxNumber)
            {
                currentNumber = latest + penultimate;

                if (isEven(currentNumber)) 
                {
                    sum += currentNumber;
                }

                penultimate = latest;
                latest = currentNumber;
                
                i++;
            }

            return sum;
        }

        static bool isEven(int number) 
        {
            return number % 2 == 0;
        }
    }
}
