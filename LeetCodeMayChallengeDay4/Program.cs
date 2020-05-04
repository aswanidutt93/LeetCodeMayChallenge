using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            FindComplement(5);
        }

        public static int FindComplement(int num)
        {
            return Convert.ToInt32(string.Join("",Convert.ToString(num, 2).Select(x => x == '1' ? '0' : '1')),2);
        }
    }
}
