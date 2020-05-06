using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 2, 1, 1, 2 };
            MajorityElement(nums);
            MajorityElement2(nums);
        }

        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1) { return nums[0]; };
            int count = 0;
            int candidate = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }
                if (candidate == nums[i])
                {
                    count++;
                }
                else count--;
            }

            return candidate;
        }

        public static int MajorityElement2(int[] nums)
        {
            Dictionary<int, int> countDic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (countDic.ContainsKey(item))
                {
                    countDic[item] = countDic[item] + 1;
                }
                else
                {
                    countDic.Add(item, 1);
                }
            }

            int count = 0;
            int candidate = 0;

            foreach (var d in countDic)
            {
                if (d.Value > count)
                {
                    count = d.Value;
                    candidate = d.Key;
                }
            }
            return candidate;
        }

    }
}
