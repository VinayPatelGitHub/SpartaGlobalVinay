using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int count = 0;
            int size = nums.Length;
            int result = nums[0];
            while (count < size)
            {
                if (nums[count] > result)
                {
                    result = nums[count];
                }
                count++;
            }
            return result;
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            int size = nums.Length;
            int result = nums[0];
            for (int i = 1; i < size; i++)
            {
                if (nums[i] > result)
                {
                    result = nums[i];
                }
            }
            return result;

        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            int result = nums[0];
            foreach (int i in nums)
            {
                if (result != i)
                {
                    if (i > result)
                    {
                        result = i;
                    }
                }
            }
            return result;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int result = nums[0];
            int size = nums.Length;
            int count = 1;
            do
            {
                if (nums[count] > result)
                {
                    result = nums[count];
                }
                count++;
            } while (count < size);
            return result;
        }
    }
}