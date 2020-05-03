using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay3
{
    public class Program
    {
        static void Main(string[] args)
        {
            CanConstruct("aa", "aab");
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {

            int[] rArray = new int[26];
            int[] mArray = new int[26];

            foreach (var r in ransomNote)
            {
                rArray[r-97]++;
            }

            foreach (var m in magazine)
            {
                mArray[m-97]++;
            }

            for(int i = 0; i < 26; i++)
            {
                if (rArray[i] > mArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
