using System;

namespace Lab_04___Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DoThis(10, "hello guys");
            var result = DoThis2("hello guys");
            DoThis3("hello guys");
        }

        public static int DoThis(int x, string y)
        {
            Console.WriteLine(y);
            return x * x;
        }

        public static int DoThis2(string y)
        {
            Console.WriteLine(y);
            return x * x;
        }

        public static void DoThis3(string y)
        {
            Console.WriteLine(y);            
        }
    }
}
