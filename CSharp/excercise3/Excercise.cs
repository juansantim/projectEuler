using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectEuler.excercise3
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */
    public class Excercise
    {
        public void Run()
        {
            long number = 600851475143;
            
            long remainder = number;
            int primeNumber = 2;
             
            List<long> factors = new List<long>();
            
            while (!(isPrime(remainder)))
            {
                if (remainder % primeNumber == 0)
                {
                    remainder = remainder / primeNumber;
                    
                    if (isPrime(remainder))
                    {
                        factors.Add(remainder);
                    }

                    factors.Add(primeNumber);
                }
                else
                {
                    primeNumber = FetchNextPrimeNumber(primeNumber);
                }


            }

            printPrimeFactor(number, factors);

        }

        private int FetchNextPrimeNumber(int primeNumber)
        {
            int nextNumber = primeNumber + 1;
            while (!isPrime(nextNumber))
            {
                nextNumber++;
            }
            return nextNumber;
        }

        long ToInt(int number)
        {
            return Convert.ToInt32(number);
        }

        private void printPrimeFactor(long number, List<long> primeFactor)
        {
            Console.WriteLine(string.Format("------>{0}<------", number));

            Console.Write("[ ");
            foreach (var item in primeFactor.OrderBy(c => c))
            {
                Console.Write(string.Format("{0} ", item));
            }
            Console.Write("]");
        }

        private List<long> GetPrimeNumbersUntil(long number)
        {
            List<long> numbers = new List<long>();

            if (number == 1)
            {
                return numbers;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (isPrime(i))
                    {
                        numbers.Add(i);
                    }
                }
            }

            return numbers;
        }

        private bool isPrime(long number)
        {
            int divisors = 0;

            if (number < 2)
                return false;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors += 1;
                }

                if (i < number && divisors > 1)
                {
                    return false;
                }

            }

            return divisors <= 2;

        }
    }
}
