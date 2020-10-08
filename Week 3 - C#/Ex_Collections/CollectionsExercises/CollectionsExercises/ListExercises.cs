
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var myList = new List<int>();
            for (int i = 0; i <= max; i++)
            {
                myList.Add(i*5);
            }
            return myList;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            if (argList.Count == 0)
            {
                return 0;
            }
            double sum = 0;           
            foreach (double item in argList)
            {
                sum += item;
            }
            double average = sum / argList.Count;
            
            return average;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var Result = new List<string>();
            int count = 0;
            foreach (string strings in sourceList)
            {
                string stringsss = strings.ToUpper();
                if (stringsss[0] == 'A')
                {
                    Result[count] = stringsss;
                    count++;
                }

            }
            
            return Result;
        }
    }
}
  