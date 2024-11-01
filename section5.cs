using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2024_31231023065
{
    internal class section5
    {
        public static void Main()
        {
            Console.WriteLine(CalculatingFactorial(3));
            Console.WriteLine(CheckingPrimeNumber(61));
            Console.WriteLine(CheckingPrimeNumber(62));
            Console.Write("Get prime numbers smaller than ");
            int limit = int.Parse(Console.ReadLine());
            List<int> primenums = SmallerPrimeNumbers(limit);
            Console.WriteLine($"Prime numbers less than {limit}: {string.Join(", ", primenums)}");
            Console.Write("Input N for the N prime number, N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(NPrimeNum(N));
        }


        public static int CalculatingFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return CalculatingFactorial(n-1)*n;
        }

        public static bool CheckingPrimeNumber(int n)
        {
            int c = 0;
            for (int i = 1; (i <= n); i++)
            {
                if (n%i == 0) 
                {
                    c ++;
                    if (c == 3) { return false; }
                }
            }
            return true;
        }

        public static List<int> SmallerPrimeNumbers(int limit)
        {
            List<int> primenums = new List<int>();
            for (int i = 2; i < limit; i++)
            {
                if (CheckingPrimeNumber(i))
                {
                    primenums.Add(i);
                }
            }
            return primenums;
        }

        public static int NPrimeNum(int n)
        {
            int c = 0;
            int res = 0;
            for (int i = 2; c < n; i++)
            {
                if (CheckingPrimeNumber(i))
                {
                    c++;
                    res = i;
                }           
            }
            return res;
        }
    }
}
