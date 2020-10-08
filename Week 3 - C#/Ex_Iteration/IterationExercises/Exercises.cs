using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Text;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int size = nums.Length;
            int result = Int32.MaxValue;
            for (int i = 0; i < size; i++)
            {
                if (nums[i] < result)
                {
                    result = nums[i];
                }
                
            }
            return result;

        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            int size2 = max;
            for (int i = 0; i <= size2; i++)
            {
                if (i%2 ==0 || i%5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            StringBuilder sb = new StringBuilder();
            int sumA = 0;
            int sumB = 0;
            int sumC = 0;
            int sumD = 0;
            int size3 = input.Length;
            for (int i = 0; i < size3; i++)
            {
                if (input[i] == 'A')
                {   sumA += 1; }
                else if (input[i] == 'B')
                {   sumB += 1; }
                else if (input[i] == 'C')
                {   sumC += 1; }
                else if (input[i] == 'D')
                {   sumD += 1; }
            }
            string result = "A:" + sumA + " B:" + sumB + " C:" + sumC + " D:" + sumD;
            return result;
        }
    }
}