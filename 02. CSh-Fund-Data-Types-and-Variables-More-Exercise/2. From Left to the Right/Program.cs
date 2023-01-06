using System;
using System.Threading;

namespace _2._From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string left = string.Empty;
                string right = string.Empty;
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] != ' ')
                    {
                        char current = input[j];
                        left += current;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int k = count+1; k < input.Length; k++)
                {
                    char current = input[k];
                    right += current;
                }
                long leftNum = long.Parse(left);
                long rightNum = long.Parse(right);
                long maxNumber = Math.Max(leftNum, rightNum);

                long sumMax = 0;
                long maxCopy = maxNumber;
                while (Math.Abs(maxCopy) > 0)
                {
                    sumMax += maxCopy % 10;
                    maxCopy /= 10;
                }
                Console.WriteLine(Math.Abs(sumMax));


            }
            
        }
    }
}
