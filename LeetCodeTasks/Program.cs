using LeetCodeTasks.Find_the_Difference_of_Two_Arrays;
using LeetCodeTasks.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TwoSum test
            /*int[] TwoSumAnswer = SolutionTwoSum.TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine(string.Join(", ", TwoSumAnswer));*/

            // DiffOfArrays test
            /*IList<IList<int>> FindTheDiffOfArrs = FindTheDiffOfTwoArrays.FindDifference(new int[] { 1, 5, 3, 2 }, new int[] { 1, 5, 3, 4 });
            foreach (IList<int> list in FindTheDiffOfArrs)
            {
                foreach (int item in list)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();*/

            // Palindrome test
            /*bool answer = PalindromNumber.PalindromNum.IsPalindrome(121);
            bool answer2 = PalindromNumber.PalindromNum.IsPalindromeWithString(12);
            Console.WriteLine(answer2);*/
        }
    }
}
