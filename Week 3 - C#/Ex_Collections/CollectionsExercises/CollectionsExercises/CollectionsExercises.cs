using System;
using System.Collections.Generic;
using System.Drawing;

namespace CollectionsExercises
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string Result2 = "";
            for (int i = 0; i < num; i++) 
            {
                if (i == Result2.Length)
                {
                    break;
                }
                Result2 = $"{queue.Dequeue()} ,";
            }
             
            return null;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var myStack = new Stack<int>(original);
            int size = original.Length;
            int[] Result = new int[size];
            //foreach(int item in original)
            //{
            //    myStack.Push(item);
            //}
            for (int i = 0; i < original.Length; i++)
            {
                Result[i] = myStack.Pop();
            }

            return Result;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var myDictionary = new Dictionary<char, int>();
            foreach (char num in input)
            {
                if (char.IsDigit(num) == true) //IsDigit only 0-9

                {
                    if (myDictionary.ContainsKey(num) == true)
                    {
                        myDictionary[num] += 1;
                    }
                    else
                    {
                        myDictionary.Add(num, 1);
                    }
                }
            }
            string Result = "";
            foreach (char i in myDictionary.Keys)
            {
                Result += $"[{i}, {myDictionary[i]}]";
            }
           return Result;
        }
    }
}