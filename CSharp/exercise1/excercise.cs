using System;

namespace projectEuler
{
    public class Excercise1
    {
        public static void Run()
        {

        }

        static void GetSumRecursive() 
        {

        }

   

        static void GetSumNormal()
        {
            var limit = 1000;
            var sum = 0m;

            for (int number = 1; number <= limit; number++)
            {
                if (IsDigitOf3Or5(number))
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }

        static bool IsDigitOf3Or5(int number)
        {
            return (number % 3 == 0 || number % 5 == 0);

        }
    }
}