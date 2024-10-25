using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2024_31231023065
{
    internal class section4
    {
        public static void Main()
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
            if (unit == "k" || unit =="K")
            { 
                Console.WriteLine("Travel speed is: " + (distance / time) + "(km/h)");
                Console.WriteLine("Or " + (distance / time)*0.621371 + "(miles/h)");
            }
            else if (unit == "m" || unit == "M")
            { 
                Console.WriteLine("Travel speed is: " + (distance / time) + "(miles/h)");
                Console.WriteLine("Or " + (distance / time)/0.621371 + "(km/h)");
            }
        }

    }
}
