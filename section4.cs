using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2024_31231023065
{
    internal class section4
    {
        public static void Main4()
        {
            Question5();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }

        /// <summary>
        /// to convert from degrees Celsius to Kelvin and Fahrenheit
        /// </summary>
        public static void Question1()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            number = number % 2;
            if (number == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }

        }
        /// <summary>
        /// Inpur Radius for calculating surface and volume
        /// </summary>
        public static void Question2()
        {
            Console.Write("Enter 1st number: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter 2sd number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            float c = float.Parse(Console.ReadLine());
            float biggest = a;
            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            Console.WriteLine("The biggest number is: " + biggest);
        }
        /// <summary>
        /// Input a and b for calculating adding, subtracting,  multiplying and dividing 
        /// </summary>
        public static void Question3()
        {
            Console.Write("Enter x-axis value: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y-axis value: ");
            float y = float.Parse(Console.ReadLine());
            if (x == 0)
            {
                if (y == 0)
                {
                    Console.WriteLine("The given point is located at the origin");
                }
                else
                {
                    Console.WriteLine("The given point is located on the y-axis");
                }
            }
            else if (y == 0)
            {
                Console.WriteLine("The given point is located on the x-axis");
            }
            else if (y > 0)
            {
                if (x > 0)
                {
                    Console.WriteLine("The given point is located in the first quadrant");
                }
                else
                {
                    Console.WriteLine("The given point is located in the second quadrant");
                }
            }
            else if (y < 0)
            {
                if (x < 0)
                {
                    Console.WriteLine("The given point is located in the third quadrant");
                }
                else
                {
                    Console.WriteLine("The given point is located in the fourth quadrant");
                }
            }
        }
        public static void Question4()
        {
            do
            {
                // Input three sides of the triangle
                Console.Write("Insert three sides of the triangle! First side: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Second side: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Third side: ");
                float c = float.Parse(Console.ReadLine());

                // Check if the sides are valid to form a triangle
                if ((a > 0)
                    && (b > 0)
                    && (c > 0)
                    && (a <= b + c)
                    && (b <= a + c)
                    && (c <= a + b)
                    )
                {
                    if (a == b)
                    {
                        if (b == c)
                        {
                            Console.WriteLine("This triangle is Equilateral");
                        }
                        else { Console.WriteLine("This triangle is Isosceles"); }
                    }
                    else if (b == c)
                    {
                        Console.WriteLine("This triangle is Isosceles");
                    }
                    else if (a == c)
                    {
                        Console.WriteLine("This triangle is Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("This triangle is Scalene");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please, try again!");
                }
            }
            while (true);
        }
        public static void Question5()
        {
            // Input necessary numbers
            // Distance
            Console.Write("Input travel distance: ");
            int distance = int.Parse(Console.ReadLine());
            Console.Write("Is the distance in kilometer or mile (k/m)?");
            string unit = Console.ReadLine();

            // Time
            Console.Write("Input travel hours: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Input travel minutes: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input travel seconds: ");
            int s = int.Parse(Console.ReadLine());
            float time = h + m / 60 + s / 3600;

            // Output
            if (unit == "k" || unit == "K")
            {
                Console.WriteLine("Travel speed is: " + (distance / time) + "(km/h)");
                Console.WriteLine("Or " + (distance / time) * 0.621371 + "(miles/h)");
            }
            else if (unit == "m" || unit == "M")
            {
                Console.WriteLine("Travel speed is: " + (distance / time) + "(miles/h)");
                Console.WriteLine("Or " + (distance / time) / 0.621371 + "(km/h)");
            }
        }
        public static void Question6()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                float result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }
            Console.ReadKey();
        }
        public static void Question7()
        {
            Console.WriteLine("Enter the pattern number that you want to see (1, 2, 3): ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Insert the rows: ");
                    int rows = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int k = 1;
                    Console.Write("Insert the rows: ");
                    int row1s = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= row1s; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{k} ");
                            k++;
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    int k1 = 1;
                    Console.Write("Insert the rows: ");
                    int row2s = int.Parse(Console.ReadLine());
                    int space = row2s + 4 - 1;
                    for (int i = 1; i <= row2s; i++)
                    {
                        for (int spc = space; spc >= 1; spc--)
                            Console.Write(" ");
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{k1} ");
                            k1++;
                        }
                        Console.WriteLine();
                        space--;
                    }
                    break;
            }          
            Console.ReadKey(); 
        }
        public static void Question8()
        {
            float s = 0;
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write($"1/{i} + ");
                    s += (float)1 / i;
                }
                else if (i == n)
                {
                    Console.Write($"1/{i}");
                    s += (float)1 / i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the series upto {0} terms: {1}", n, s);
            Console.ReadKey();
        }
        public static void Question9()
        {
            Console.Write("Insert the start of the range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Insert the end of the range: ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int kq = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        kq += j;
                }
                if (i == kq)
                    Console.WriteLine("{0} is the perfect number", i);
            }
            Console.ReadKey();
        }
        public static void Question10()
        {
            int demUoc = 0;
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    demUoc++;
            }
            if (demUoc == 2)
                Console.WriteLine($"{n} is a prime number");
            else
                Console.WriteLine($"{n} is not a prime number");
            Console.ReadKey();
        }
        public static void Question11()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y*y + 2*y + 1;
                Console.WriteLine("Certain value of function x when y = {0} la: {1}",y,x);
            }
            Console.ReadKey();
        }
        public static void Question12() 
        {
            /*Console.Write("Input the character: ");
            if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i'|| c == 'A' || c == 'E' || c == 'O' || c == 'U' || c == 'I')
            {
                Console.WriteLine("The character you insert is vowel");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("The character you insert is digit");
            }
            else
                Console.WriteLine("The character you insert is other symbol"); */
        }
    }
}
        
