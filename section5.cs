using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2024_31231023065
{
    internal class section5
    {
        public static void Main5()
        {
            //Console.WriteLine(CalculatingFactorial(3));
            //Console.WriteLine(CheckingPrimeNumber(61));
            //Console.WriteLine(CheckingPrimeNumber(62));
            //Console.Write("Get prime numbers smaller than ");
            //int limit = int.Parse(Console.ReadLine());
            //List<int> primenums = SmallerPrimeNumbers(limit);
            //Console.WriteLine($"Prime numbers less than {limit}: {string.Join(", ", primenums)}");
            //Console.Write("Input N for the N prime number, N: ");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine(NPrimeNum(N));
            //PerfNumLessThan1000();
            Console.Write("Input string: ");
            string str = Console.ReadLine();
            if (CheckPangram(str))
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
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

        public static bool CheckPerfectNum(int num)
        {
            int SumDivisors = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    SumDivisors += i;
                }
            }
            if (SumDivisors == num) { return true; }
            return false;
        }

        public static void PerfNumLessThan1000()
        {
            for (int i = 1; i < 1000; i++) 
            {
                if (CheckPerfectNum(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static bool CheckPangram(string str)
        {
            HashSet<char> alphabet = new HashSet<char>();
            foreach (char c in str)
            {
                if ('a' <= c && c <= 'z')
                {
                    alphabet.Add(c);
                }
                else if ('A' <= c &&  c <= 'Z')
                {
                    alphabet.Add(char.ToLower(c));
                }
            }
            if (alphabet.Count == 26) { return true; }
            return false;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static int[] IncreaseArray(int[] array, int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += val;
            }
            return array;
        }

        public static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
}
