using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = FirstUniqChar("loveleetcode");
        }

        public static int FirstUniqChar(string s)
        {
            int[] alphArray = new int[26];
            int index = -1;
            for (int i = 0; i < s.Length; i++)
            {
                alphArray[s[i] - 97]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (alphArray[s[i] - 97] < 2)
                {
                    return index = i;
                }               
            }

            return index;
        }
    }
}
