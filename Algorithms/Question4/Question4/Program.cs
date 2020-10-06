using System;
using System.Collections.Generic;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "abcabcd";
            var output = NumberOfSubstrings(s);

            Console.Write(output);
            Console.ReadLine();
        }

        static int NumberOfSubstrings(string s)
        {
            int[] counts = new int[3];
            int i = 0;
            int x = 0;

            int res = 0;
            IList<(int from, int to)> intervals = new List<(int @from, int to)>();
            while (i < s.Length)
            {
                if (x < s.Length && (counts[0] == 0 || counts[1] == 0 || counts[2] == 0))
                {
                    counts[s[x] - 'a']++;
                    x++;
                    continue;
                }

                if (counts[s[i] - 'a'] <= 1)
                {
                    if ((counts[0] > 0 && counts[1] > 0 && counts[2] > 0))
                    {
                        intervals.Add((i, x));
                    }
                }

                counts[s[i] - 'a']--;
                i++;
            }

            for (int k = 0; k < intervals.Count; k++)
            {
                if (k == 0)
                {
                    res += (intervals[k].from + 1) * (s.Length - intervals[k].to + 1);
                    continue;
                }

                res += (intervals[k].from - intervals[k - 1].from) * (s.Length - intervals[k].to + 1);
            }

            return res;
        }
    }
}
