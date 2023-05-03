using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Find_the_Difference_of_Two_Arrays
{
    public static class FindTheDiffOfTwoArrays
    {
        // https://leetcode.com/problems/find-the-difference-of-two-arrays/
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            return new[] {
                 nums1.Except(nums2).ToList(),
                 nums2.Except(nums1).ToList()
            };
        }

    }
}
