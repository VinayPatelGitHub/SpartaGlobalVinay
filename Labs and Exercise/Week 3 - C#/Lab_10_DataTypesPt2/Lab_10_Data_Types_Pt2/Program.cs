using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Lab_10_Data_Types_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            var d = new DateTime();
            var d1 = DateTime.Today;
            var d2 = DateTime.Now;
            var d3 = new DateTime(2020, 7, 12, 10, 5, 18);
            d = d.AddDays(1);
            d = d.AddMonths(1);
            var output = DateTime.Now.ToString("dd-MM-yyyy");
            var output2 = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            var date = new DateTime(1989, 11, 02);
            var date2 = date.ToString("yyyy/dd/MMM");

            var timespan = new TimeSpan(1, 0, 0);
            var date3 = DateTime.Now + timespan;
            var tick = new TimeSpan(1);
            date3 = date3 + tick;

            var s = new Stopwatch();
            s.Start();
            int total = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                total += i;
            }
            s.Stop();
            Console.WriteLine(s.Elapsed);
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);

            //Enumerated Types
            Suit theSuit = Suit.HEARTS;
            Console.WriteLine(theSuit);
            Console.WriteLine($"Sunday as a number is {(int)DayOfWeek.Sunday}");

            //Defualt Values
            bool? hasPassed = true;
            if (hasPassed.HasValue)
            {
                Console.WriteLine("hasPassed is not null");
            }
            hasPassed = null;
            if (hasPassed.HasValue)
            {
                Console.WriteLine("hasPassed is not null");
            }
            Console.WriteLine("hasPassed is null");

            int totalCost = 0;
            int price = 1;
            int? items = null;
            if (items.HasValue)
            {
                totalCost = items.Value * price;
            }
            // totalCost = items.Value * price; ??
            Console.WriteLine(totalCost);

            int? nullableScore = null;
            int score = nullableScore ?? -9999;
            int score1 = nullableScore.GetValueOrDefault(-1);
            int score2 = nullableScore.GetValueOrDefault();

            //const
            const int dozen = 12;
            dozen = 11;
            //readonly - same for class field
            //dynamic
            dynamic item = 100;
            Console.WriteLine($"adding 10 to {item} gives you {item+10}");
            item = "Nish";
            Console.WriteLine($"adding 10 to {item} gives you {item + 10}");

            //random
            var rollTheDice = new Random();
            Console.WriteLine(rollTheDice.Next(1, 6));
            Console.WriteLine(rollTheDice.Next(1, 6));
            Console.WriteLine(rollTheDice.Next(1, 6));

            var rngUnseeded = new Random();
            var rngSeeded = new Random(42);
            var rngSeeded1 = new Random(42);
            var between1And10noSeed = rngUnseeded.Next(1, 11);
            var between1And10Seeded = rngSeeded.Next(1, 11);
            var between1And10Seeded1 = rngSeeded1.Next(1, 11);
            Console.WriteLine(between1And10noSeed);
            Console.WriteLine(between1And10Seeded);
            Console.WriteLine(between1And10Seeded1);
        }

            //Enumerated Types
        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }

        public static void Suits(Suit suit)
        {
            switch(suit)
            {
                case (Suit.HEARTS):
                    Console.WriteLine("HEART");
                    break;
                case (Suit.CLUBS):
                    Console.WriteLine("HEART");
                    break;
                case (Suit.DIAMONDS):
                    Console.WriteLine("HEART");
                    break;
                case (Suit.SPADES):
                    Console.WriteLine("HEART");
                    break;
            }
        }

        
    }
}
