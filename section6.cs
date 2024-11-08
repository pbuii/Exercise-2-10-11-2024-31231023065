using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2024_31231023065
{
    internal class section6
    {
        public static void Main()
        {
            int[] array = InputArray();
            PrintArray(array);
            PrintArray(IncreaseArray(array, 2));
            Console.WriteLine(SumArray(array));
            string[][][] j_array = new string[3][][];
            j_array[0] = new string[] {}
        }

        public static int[] InputArray() 
        {
            Console.Write("Input number of elements in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input the #{i + 1} element of the array: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
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
