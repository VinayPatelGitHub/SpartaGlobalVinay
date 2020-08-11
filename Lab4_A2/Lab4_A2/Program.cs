using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Schema;

namespace Lab4_A2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var result = DoThis(12, "Hello Eng65", out bool a);
        //    Console.WriteLine(a);
        //}

        //public static int DoThis(int x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 10);
        //    return x * x;
        //}



        //static void Main(string[] args)
        //{
        //    int number = 10;
        //    Add(number);
        //    Console.WriteLine(number);

        //    Add(ref number);
        //    Console.WriteLine(number);
        //}

        //public void Add(int num)
        //{
        //    num++;
        //}




        //static void Main(string[] args)
        //{
        //    var myTuple = ("Nish", "Mandal", 30);
        //    Console.WriteLine(myTuple);
        //    Console.WriteLine(myTuple.Item1);

        //}

        //{
        //    var game = "Aniimal Crossing";
        //    var rating = 3;
        //    var myTuple2 = (game, rating);
        //    Console.WriteLine(myTuple2.game);
        //    Console.WriteLine(myTuple2.Item1);

        //}


        //static void Main(string[] args)
        //{
        //    var result = DoThat(11, "here's a string");
        //    Console.WriteLine(result);
        //    Console.WriteLine(result.xsquared);

        //    var (sqaure, greaterThan10) = DoThat(5, "Hello");  //this similar to python
        //    Console.WriteLine(greaterThan10);
        //}
        //public static (int xsquared, bool y_gt_10) DoThat(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z);

        //}


        //OVERLOADING AND OVERRIDING
        //OVERLOADING - SAME NAME BUT DIFFERNT VARIABLE INPUTS SO MAKE THE PROGRAM MORE RELAIBLE EXPLCITILY - SOMETHING TO DO WITH POLYMORPHISIM

        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            int c = 7;

            int prod1 = TripleCalc(a, b, c, out int sum1);
            Console.WriteLine(sum1);
            Console.WriteLine(prod1);

            (int sum2, int prod2) = TripleCalc(a, b, c);
            Console.WriteLine(sum2);
            Console.WriteLine(prod2);
        }

        public static int TripleCalc(int a, int b, int c, out int z)
        {
            z = a + b + c;
            return (a * b * c);
        }

        public static (int,int) TripleCalc(int a, int b, int c)
        {
            int p = (a * b * c);
            int s = (a + b + c);
            return (p, s);

        }


    }
}
