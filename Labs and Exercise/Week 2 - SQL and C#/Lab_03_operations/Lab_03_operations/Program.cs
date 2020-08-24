using System;

namespace Lab_03_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;

            c += +a+++ ++b;
            Console.WriteLine(c);
        }
    }
}
