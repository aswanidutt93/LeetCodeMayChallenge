using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveKDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var res=RemoveKdigits("100", 1);
        }

        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length <= k) { return "0"; }
            var res = string.Empty;
            Stack<char> fStack = new Stack<char>();
            foreach (var item in num)
            {
                while (fStack.Any() && fStack.Peek() > item && k > 0)
                {
                    fStack.Pop();
                    k--;
                }
                fStack.Push(item);
            }

            while (fStack.Any() && k > 0)
            {
                fStack.Pop();
                k--;
            }
            res = new string(fStack.Reverse().ToArray());
            int zeroCount = 0;
            int nonZeroCount = 0;


            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    nonZeroCount++;
                    break;
                }
            }

            if (zeroCount > 0) {
                if(nonZeroCount > 0)
                {
                    res = res.Substring(zeroCount);
                }
                else
                {
                    res = "0";
                }
                
            }


            return res;
        }

       
    }
}
