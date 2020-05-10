using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay10
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = new int[][] {[1, 2]; };
            int[][] array2D = new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 } };
            var res = FindJudge(3, array2D);
        }

        public static int FindJudge(int N, int[][] trust)
        {
            int[] count = new int[N + 1];
            foreach (var item in trust)
            {
                count[item[0]]--;
                count[item[1]]++;
            }

            for (int i = 0; i < N + 1; i++)
            {
                if (count[i] == N - 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
