using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "horse";
            string word2 = "ros";

            var output = MinDistance(word1, word2);
            Console.Write(output);
            Console.ReadLine();
        }
        static int MinDistance(string word1, string word2)
        {

            int[,] minD = new int[word1.Length + 1, word2.Length + 1];

            for (int i = word1.Length - 1; i >= 0; i--)
            {
                minD[i, word2.Length] = minD[i + 1, word2.Length] + 1;
            }

            for (int x = word2.Length - 1; x >= 0; x--)
            {
                minD[word1.Length, x] = minD[word1.Length, x + 1] + 1;
            }

            for (int i = word1.Length - 1; i >= 0; i--)
            {
                for (int x = word2.Length - 1; x >= 0; x--)
                {
                    if (word1[i] == word2[x])
                    {
                        minD[i, x] = minD[i + 1, x + 1];
                    }
                    else
                    {
                        minD[i, x] = Math.Min(minD[i + 1, x], minD[i, x + 1]);
                        minD[i, x] = Math.Min(minD[i, x], minD[i + 1, x + 1]);
                        minD[i, x]++;
                    }
                }
            }
            return minD[0, 0];
        }
    }
}
