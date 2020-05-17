using System;
using System.Collections.Generic;

namespace AnagramsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAnagrams("cbaebabacd", "abc");
            Console.WriteLine("Hello World!");
        }

        public static IList<int> FindAnagrams(string s, string p)
        {
            List<int> li = new List<int>();

            
            int[] pArray = new int[26];
            for (int i = 0; i < p.Length; i++)
            {
                pArray[p[i] - 97]++;
            }

            for (int i = 0; i < s.Length - p.Length; i++)
            {
                int[] sArray = new int[26];
                var sstr = s.Substring(i, p.Length);
                for (int j = 0; j < sstr.Length; j++)
                {
                    sArray[sstr[j] - 97]++;
                }

                int count = 0;
                for (int k = 0; k < 26; k++)
                {
                    if (pArray[k] == sArray[k])
                    {
                        count++;
                    }
                }

                if (count == 26)
                {
                    li.Add(i);
                }



            }


            
            return li;
        }
    }
}
