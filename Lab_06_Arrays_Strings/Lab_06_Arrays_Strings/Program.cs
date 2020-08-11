﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Lab_06_Arrays_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[4];
            

            letters[0] = 'n'; //'' are for chars, "" for strings
            letters[1] = 'i';
            letters[3] = 'h';
            letters[2] = 's';

            var letters2 = new char[4] { 'n', 'i', 's', 'h'};

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            ArraySum(numbers);

            // 2d array: 2 rows, 4 columns
            int[,] grid = new int[2, 4];
            // 4d array:
            int[,,,] grid4d = new int[3, 4, 2, 3];

            int[,] grid2d = {{4,7,6,8 }, {6,1,7,10 }};
            int val = grid2d[2,1];

            //unsure?
            string[][] animalGrid = new string[2][];
            animalGrid[0] = new string[4];
            animalGrid[1] = new string[2];

            string[][] eng65Grid = new string[][]
                {
                    new string []{"Terrance", "Fazal", "Diogo", "James"},
                    new string [] {"Huthaifa", "Vinay"}
                };
            var spartan = eng65Grid[1][1];

            //strings - mutable 
            List<string> parts = new List<string> ();
            parts.Add("wheels");
            parts.Add("gear box");
            parts.Add("exhaust");
            parts.Add("wipers");

            var beatles = new List<string>() { "Paul", "John", "George", "Ringo" };
            string beatleMember = beatles[1];
            foreach (var item in beatles)
            {
                Console.WriteLine(item);
            }

            //string
            string name = "Huthaifa";
            int length = name.Length;
            var upperCaseName = name.ToUpper();
            var spaceName = "   Huathiafa    ";
            var trimmedName = spaceName.Trim();

            var thirdletter = name[2];
            var allChars = name.ToCharArray();
            var midChars = name.ToCharArray(1, 3);

            foreach (var item in midChars)
            {
                Console.WriteLine(item);
            }

            string fName = "Vinay";
            string lName = "Patel";
            double score = 0.5;
            var string1 = fName + "" + lName + " Score: " + score;
            string string2 = $"{fName} {lName} Score: {score:p2}";

            Console.WriteLine("How many apples?");
            string input = Console.ReadLine(); //concole inputs are strings
            int numApples = Int32.Parse(input);
            bool success = Int32.TryParse(input, out int numApples2);
            Console.WriteLine(numApples);

            //StringBuilder
            StringBuilder sb = new StringBuilder("Hello ");
            sb.AppendLine("World!");
            sb.Append("And class");
            SqlGuid.Remove(2, 2); //starts at 2 and removes 2
            string hw = sb.ToString();

            Console.WriteLine(sb);
            Console.WriteLine(" ");
            Console.WriteLine(hw);












        }

        public static int ArraySum(int[] practiceArray)
        {
            int sum = 0;
            foreach (var item in practiceArray)
            {
                sum += item;
            }

            return sum;
        }
    }
}
