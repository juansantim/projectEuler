using System;
using System.Collections.Generic;
using System.Text;

namespace projectEuler.SandBox
{
    public class RecursionVsIteration
    {
        static void Run() 
        {
            int from = 1;
            int to = 1000;

            //Excercise1.Run();
            var sum1 = GetSumBetween(from, to);
            Console.WriteLine($"Loop Sum {sum1}");

            var sum2 = RecursiveSum(from, to);
            Console.WriteLine($"Recursive Sum {sum2}");


            Console.ReadKey();
        }

        static int GetSumBetween(int fromNomber, int toNumber)
        {
            int sum = 0;
            for (int i = fromNomber; i <= toNumber; i++)
            {
                sum += i;
            }

            return sum;
        }

        static void PrintRecursiveArray(int fromNumber, int toNumber)
        {
            if (fromNumber <= toNumber)
            {
                Console.WriteLine(fromNumber);
                fromNumber++;
                PrintRecursiveArray(fromNumber, toNumber);
            }

        }
        static int RecursiveSum(int fromNumber, int toNumber)
        {
            int sum = fromNumber;

            if (fromNumber < toNumber)
            {
                fromNumber++;
                return sum += RecursiveSum(fromNumber, toNumber);
            }

            return sum;

        }
    }
}
