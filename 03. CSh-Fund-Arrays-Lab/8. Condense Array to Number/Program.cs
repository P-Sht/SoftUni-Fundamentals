using System;
using System.Linq;


namespace _8.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
            }
            Console.WriteLine(nums[0]);
        }
    }
}
