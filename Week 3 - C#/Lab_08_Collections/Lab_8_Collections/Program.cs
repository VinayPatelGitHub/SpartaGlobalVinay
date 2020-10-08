using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_8_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple
            (bool, string, int) Vinay = (true, "lad", 15);
            bool output1 = Vinay.Item1;
            string output2 = Vinay.Item2;
            int output3 = Vinay.Item3;

            //Array Lists
            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add(1);
            // won't be using arraylists

            //Lists
            List<int> nums = new List<int> { 1, 3, 8, 12 };
            var myList = new List<int>() { 1, 2, 3 };

            var myList2 = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int num in myList2)
            {
                Console.WriteLine(num);
            }
            myList2.Add(6);
            myList2.Add(7);
            myList2.Add(8);
            myList2.Insert(2, 4);
            myList2.Reverse();
            myList2.RemoveAt(3);
            myList2.Sort();
            Console.WriteLine(myList2);

            //Queue - first in first out
            var myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            Console.WriteLine(myQueue.Peek());
            myQueue.Dequeue();
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Contains(3));

            //Stack - last in first out
            var myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            int output = myStack.Pop();
            Console.WriteLine(output);
            Console.WriteLine(myStack.Peek());

            //HashSet 
            var names = new List<string> { "Vinay", "Nish", "James" };
            HashSet<string> hSet = new HashSet<string>(names);
            Console.WriteLine(output);
            //Hashcode - something to do with where data is saved.

            //Dictionary
            var beatlesDict = new Dictionary<int, string>();
            beatlesDict.Add(1, "John");
            beatlesDict.Add(2, "Paul");
            beatlesDict.Add(3, "George");
            beatlesDict.Add(4, "Ring");

            var numDict = new Dictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" } };
            var numDict2 = new Dictionary<int, string>() { [1] = "one", [2] = "two", [3] = "three", [4] = "four" };

            foreach (var item in beatlesDict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            foreach (var inkey in beatlesDict.Keys)
            {
                Console.WriteLine($"{inkey} {beatlesDict[inkey]}");
            }

            Console.WriteLine(beatlesDict[1]);

            string input = "James Loves Fish and Chips";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }
            foreach ( var item in countDict)
            {
                Console.WriteLine($"{ item.Key} {item.Value}");
                Console.WriteLine(item);
            }

        }
    }
}
