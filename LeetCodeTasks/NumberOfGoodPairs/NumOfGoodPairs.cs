using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.NumberOfGoodPairs
{
    // https://leetcode.com/problems/number-of-good-pairs/submissions/943817562/
    public static class NumOfGoodPairs
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int goodpairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) goodpairs++;
                }
            }
            return goodpairs;
        }
    }
}
