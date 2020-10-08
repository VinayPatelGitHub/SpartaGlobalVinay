using System;

namespace Manual_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { };
            var result = Lowest(nums);
            Console.WriteLine(result);
        }

        public static int Lowest(int[] nums)
        {
            int size = nums.Length;
            int result = nums[0];
            for (int i = 1; i < size; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    result = nums[i];
                }

            }
            return result;

        }

    }
    
}

