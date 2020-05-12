using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
           var res= SingleNonDuplicate(arr);
        }

        public static int SingleNonDuplicate(int[] nums)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (d.ContainsKey(num))
                {
                    d[num]++;
                }
                else
                {
                    d.Add(num, 1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (d[nums[i]]==1){
                    return nums[i];
                }
            }

            return -1;
        }
    }
}
