using System;
using System.Collections.Generic;

namespace PermutationInString
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckInclusion("abc", "abcdddddddd");
            Console.WriteLine("Hello World!");
        }

        public static bool CheckInclusion(string s1, string s2)
        {
            int[] s1Arr = new int[26];
            


            for (int i = 0; i < s1.Length; i++)
            {
                s1Arr[s1[i] - 97]++;
            }

            

            for (int i = 0; i <= s2.Length - s1.Length; i++)
            {
                var s2Sub = s2.Substring(i, s1.Length);
                int[] s2Arr = new int[26];

                for (int j = 0; j < s2Sub.Length; j++)
                {
                    s2Arr[s2Sub[j] - 97]++;
                }

                int count = 0;
                for (int k = 0; k < 26; k++)
                {
                    if (s1Arr[k] == s2Arr[k])
                    {
                        count++;
                    }
                }

                if (count == 26)
                {
                    return true;
                }

                
            }



            return false;
        }
    }
}
