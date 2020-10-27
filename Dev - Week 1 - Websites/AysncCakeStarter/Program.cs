using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{

    class Program
    {

        public async static Task Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            HaveAParty();
            Console.WriteLine("Thanks for a lovely party");
            sw1.Stop();
            TimeSpan elapsedTime1 = sw1.Elapsed;
            Console.WriteLine(elapsedTime1.ToString());

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            var partyTask = HaveAPartyAsync();
            await partyTask;
            Console.WriteLine("Thanks for a lovely Async party");
            sw2.Stop();
            TimeSpan elapsedTime2 = sw2.Elapsed;
            Console.WriteLine(elapsedTime2.ToString());

            Console.ReadLine();
        }

        private static void HaveAParty()
        {
            var name = "Cathy";
            var cake = BakeCake();
            BlowUpBalloons();
            OpenPresents();
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        private async static Task HaveAPartyAsync()
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            BlowUpBalloons();
            OpenPresents();
            var cake = await cakeTask;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");

        }

        private async static Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Starting to bake");
            await Task.Delay(TimeSpan.FromSeconds(5));
            return new Cake();
        }

        private static Cake BakeCake()
        {
            Console.WriteLine("Starting to bake");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            return new Cake();
        }

        private static void BlowUpBalloons()
        {
            Console.WriteLine("Blowing up ballooons");
        }

        private static async Task BlowUpBalloonsAsync()
        {
            Console.WriteLine("Blowing up ballooons");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("Finsh up blowing up ballooons");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }
}
