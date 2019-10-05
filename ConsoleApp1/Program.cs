using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number to convert to binary: ");
            int decimale = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(decimale, 2);
            Console.WriteLine($"The converted number is {binary}");
            Console.ReadLine();
        }
    }
}
