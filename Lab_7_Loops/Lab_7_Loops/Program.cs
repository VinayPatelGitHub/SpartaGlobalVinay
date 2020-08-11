using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab_7_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            int[] myArray = { 10, 20, 30 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //foreach

            int counter = 0;
            while (counter <10)
            {
                Console.WriteLine(counter * 10);
                counter++;
            }

            int counter1 = 10;
            do
            {
                Console.WriteLine(counter1);
                counter1++;
            }
            while (counter1 < 10);

            int sum = 0;
            for (int i= 0; i<=100; i++)
            {
                sum += i;                
            }
            Console.WriteLine(sum);

            string words = "NISH IS KING";
            words = words.ToLower();
            for (int i = 0; i <= words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i==5)
                {
                    break;
                }
            }
            Console.WriteLine("broken out of loop");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }
            Console.WriteLine("broken out of loop");

            int counter2 = 0;
            while (counter2<10)
            {
                counter2++;
                Console.WriteLine(counter2);
                if (counter2 < 4) continue;
                Console.WriteLine(counter2 * 4);

            }

            Console.WriteLine("x");
            for (int x = 1; x <= 20; x++)
            {
                Console.WriteLine(x);
                if (x % 15 == 0)
                    break;
            }


        }
    }
}
