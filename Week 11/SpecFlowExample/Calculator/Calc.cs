using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calc
    {
        public static int Number1 { get; set; }
        public static int Number2 { get; set; }
        public static Table TableofNumbers { get; set; }
        private int _evenNumberSum { get; set; }
        private List<int> intList { get; set; }

        public static int Add()
        {
            return Number1 + Number2;
        }

        public static int Subtract()
        {
            return Number1 - Number2;
        }

        public static void IterateThroughTheListSelectingEvenNumbers()
        {

        }

        public static int AddEvenNumberinList()
        {

        }
    }
}
