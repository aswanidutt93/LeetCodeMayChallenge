using System;
using System.Collections;
using System.Linq;

namespace FrequencySort
{
    class Program
    {
        static void Main(string[] args)
        {
            FrequencySort("Aaaccc");
            Console.WriteLine("Hello World!");
        }


        public static string FrequencySort(string s)
        {
            return string.Join("", s.GroupBy(x => x).OrderByDescending(gr => gr.Count()).SelectMany(gr => gr));
        }
    }
}
