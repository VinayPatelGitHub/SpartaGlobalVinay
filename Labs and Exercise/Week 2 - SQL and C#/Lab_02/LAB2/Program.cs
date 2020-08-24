using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked // checks for overflow
            {
                int x = int.MaxValue;
                int z = x + 1;
                int a = x + 2;
                int b = x + 3;
                Console.WriteLine($"int mx value = {x}");
                Console.WriteLine($"int mx value = {z}");
                Console.WriteLine($"int mx value = {a}");
                Console.WriteLine($"int mx value = {b}");

                int c = Int32.MaxValue;
                int d = c + 1;
                Console.WriteLine($"int mx value = {c}");
                Console.WriteLine($"int mx value = {d}");

                double e = 1.0d/ 3.0d;
                decimal f = 1.0m / 3.0m;
                float g = 1.0f / 3.0f;

                Console.WriteLine($"int mx value = {e}");
                Console.WriteLine($"int mx value = {f}");
                Console.WriteLine($"int mx value = {g}");

                float sum = 0;

                for(int i = 0; i < 1000; i++)
                {
                    sum += 1 / 3.0f;
                }

                Console.WriteLine($"1/3 multiplied by 1000 = {sum}");
                Console.WriteLine($"1/3 multiplied by 1000 = " +1/3.0f*1000);

                char firstInitial = 'v';
                Console.WriteLine(firstInitial);

                int intInitial = (int)firstInitial;
                Console.WriteLine(intInitial);

                double t = 3.14444444444444444444444444444444444d;
                float s = (float)t;
                Console.WriteLine($"double = {t}");
                Console.WriteLine($"float = {s}"); //casting

                int intInitial2 = 108;
                char middleintitial = (char)intInitial2;
                Console.WriteLine($"{middleintitial}");

                bool likeBannnas = true;
                Console.WriteLine(likeBannnas);
                int u = Convert.ToInt32(likeBannnas);
                Console.WriteLine(u);

                double pi = 3.141592;
                pi = Math.Round(pi, 3);
                Console.WriteLine(pi);

                var name = "nish";
                var assa = 's';


            }
        }
    }
}
