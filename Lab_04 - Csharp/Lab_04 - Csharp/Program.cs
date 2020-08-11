using System;

namespace Lab_04___Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = DoThis(10, "hello guys");
        }

        public static int DoThis(int x, string y)
        {
            Console.WriteLine(y);
            return x * x;
        }
    }
}
