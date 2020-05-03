using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay1
{
    /* The isBadVersion API is defined in the parent class VersionControl.
       bool IsBadVersion(int version); */

    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int middle = left + (right - left) / 2;
                if (!IsBadVersion(middle))
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return left;
        }

    }

    public class VersionControl
    {
        public bool IsBadVersion(int val)
        {
            return true;
        }
    }
}