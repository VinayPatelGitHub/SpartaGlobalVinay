using System;

namespace Lab4_A2___class_library_file
{
    public class TripleCalc
    {
        public static int Calc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return (a * b * c);
        }
    }
}
