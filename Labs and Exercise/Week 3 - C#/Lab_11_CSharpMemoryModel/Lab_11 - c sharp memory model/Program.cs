using System;

namespace Lab_11___c_sharp_memory_model
{
    class Program
    {
        static void Main(string[] args)
        {
            var Terrance = new [] { "Hello", "World" };
            var Vinay = Terrance;
            Vinay[0] = "Good Morning";
            Console.WriteLine($"{Terrance[0]} {Terrance[1]}");
            Console.WriteLine($"{Vinay[0]} {Vinay[1]}");

            var Terrance1 = new[] { "Hello", "World" };
            string[] Vinay1 = Terrance1;
            Vinay1[1] = "Spartans";
            Console.WriteLine($"{Terrance1[0]} {Terrance1[1]}");
            Console.WriteLine($"{Vinay1[0]} {Vinay1[1]}");

            var Terrance2 = new[] { "Hello", "World" };
            var Vinay2 = new string[2];
            Terrance.CopyTo(Vinay2,0);
            Vinay2[1] = "Spartans";
            Console.WriteLine($"{Terrance2[0]} {Terrance2[1]}");
            Console.WriteLine($"{Vinay2[0]} {Vinay2[1]}");

            int x = 5;
            string y = "hello";
            if (x==5)
            {
                x = 6;
                y = "bye";
                Console.WriteLine($"{x} {y}");
            }
            Console.WriteLine($"{x} {y}");

            string help = "need help";
            Program.Helper(help);
            Console.WriteLine(help);

        }

        public static void Helper(string y)
        {
            y = "don't need help";
            Console.WriteLine(y);
        }
    }
}
