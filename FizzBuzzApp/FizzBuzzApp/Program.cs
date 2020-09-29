using System;

namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 50;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"{FizzBuzz(i)}");
            }
        }

        public static string FizzBuzz(int i)
        {
            string result = $"{i}";
            if (i % 3 == 0 && i % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result = "Fizz";
            }
            else if (i % 5 == 0)
            {
                result = "Buzz";
            }
            return result;
        }
    }

}
