using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay2
{
    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0;

            foreach (var ja in J)
            {
                foreach (var sa in S)
                {
                    if (ja == sa)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}