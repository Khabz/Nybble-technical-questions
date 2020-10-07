using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            int K = 3;

            var output = longestOnes(A, K);
            Console.Write(output);
            Console.ReadLine();
        }
        static int longestOnes(int[] A, int K)
        {
            var v1 = 0;
            var vMax = 0;
            for (var v2 = 0; v2 < A.Length; v2++)
            {
                if (A[v2] == 0)
                {
                    K--;
                }

                while (K < 0 && v1 <= v2)
                {
                    if (A[v1++] == 0)
                    {
                        K++;
                    }
                }

                vMax = Math.Max(vMax, v2 - v1 + 1);
            }

            return vMax;
        }
    }
}
