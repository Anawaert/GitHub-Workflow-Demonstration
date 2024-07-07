using System;

namespace GitHub_Flow_Demo
{
    class Program
    {
        static int Add(int x, int y) => x + y;

        static int Sub(int x, int y) => x - y;

        static int Mul(int x, int y) => x * y;

        static int Div(int x, int y) => x / y;

        static int Mod(int x, int y) => x % y;

        static int Pow(int x, int y) => (int)Math.Pow(x, y);

        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers split by a space to calculate:");
            string input = Console.ReadLine() ?? string.Empty;
            if (input.Trim().Length <= 1)
            {
                Console.WriteLine("Exit");
                return;
            }
            string[] numbers = input.Split(' ');
            Console.WriteLine("Sum: " + Add(int.Parse(numbers[0]), int.Parse(numbers[1])));
            Console.WriteLine("Sub: " + Sub(int.Parse(numbers[0]), int.Parse(numbers[1])));
            Console.WriteLine("Mul: " + Mul(int.Parse(numbers[0]), int.Parse(numbers[1])));
            Console.WriteLine("Div: " + Div(int.Parse(numbers[0]), int.Parse(numbers[1])));
            Console.WriteLine("Mod: " + Mod(int.Parse(numbers[0]), int.Parse(numbers[1])));
            Console.WriteLine("Pow: " + Pow(int.Parse(numbers[0]), int.Parse(numbers[1])));
            Console.WriteLine("Exit");
        }
    }
}