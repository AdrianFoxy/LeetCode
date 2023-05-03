using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.PalindromNumber
{
    // https://leetcode.com/problems/palindrome-number/
    public static class PalindromNum
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int revNum = 0;
            while (x > revNum)
            {
                revNum = revNum * 10 + x % 10;
                x /= 10;
            }

            if (revNum == x || x == revNum / 10) return true;
            return false;

        }

        public static bool IsPalindromeWithString(int x)
        {
            var ToReverse = x.ToString().ToCharArray();
            Array.Reverse(ToReverse);
            return x.ToString() == new string(ToReverse);
        }
    }
}
