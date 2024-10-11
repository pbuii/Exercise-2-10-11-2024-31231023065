namespace BuiLeMinhPhat {
    internal class Section_2
    {
        public static void Main()
        {
            Question_1();
            Question_2();
            Question_3();
            Question_4();
            Question_5();
            Question_6();
            Question_7();
            Question_8();
            Question_9();
            Question_10();
        }

        public static void Question_1() {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public static void Question_2()
        {
            Console.Write("Enter the A number: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter the B number: ");
            int B = int.Parse(Console.ReadLine());
            int temp = A;
            A = B;
            B = temp;
            Console.WriteLine("Value of A after being swapped: " + A);
            Console.WriteLine("Value of B after being swapped: " + B);
        }
        public static void Question_3()
        {
            Console.Write("Enter the first float number: ");
            float float1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second float number: ");
            float float2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Multiply two floating numbers: {float1*float2}");
        }
        public static void Question_4()
        {
            Console.Write("Enter an amount of length in feet: ");
            int feet = int.Parse(Console.ReadLine());
            Console.WriteLine($"Length in neger: {feet * 0.3048}");
        }
        public static void Question_5()
        {
            Console.Write("Enter a temparature (e.g. 32): ");
            float temperature = float.Parse(Console.ReadLine());
            Console.Write("Enter scale used (C/F)");
            string scale = Console.ReadLine();
            if (scale == "C") {
                Console.WriteLine($"Temparature in Farenheit: {temperature * 9 / 5 + 32}"); 
            }
            else if (scale == "F")
            {
                Console.WriteLine($"Temparature in Celcius: {(temperature - 32) / 9 * 5}");
            }
        }
        public static void Question_6()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
        }
        public static void Question_7()
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII value of '{character}': {(int)character}");
        }
        public static void Question_8()
        {
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of the circle: {radius*radius*3.14}");
        }
        public static void Question_9()
        {
            Console.Write("Enter side length of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of the square: {side*side}");
        }
        public static void Question_10()
        {
            Console.Write("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            days %= 365;
            int weeks = days / 7;
            days %= 7;
            Console.WriteLine($"{years} years, {weeks} weeks, {days} days");
        }
    }
}