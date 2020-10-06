using System;
using System.Text.Json;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n = 4;

            var output = Shuffle(nums, n);
            using JsonDocument doc = JsonDocument.Parse(JsonSerializer.Serialize(output));
            JsonElement root = doc.RootElement;

            Console.Write(root);
            Console.ReadLine();
        }

        static int[] Shuffle(int[] nums, int n)
        {
            var firstNums = new int[n];
            var secondNums = new int[n];
            for (var i = 0; i < n; i++)
            {
                firstNums[i] = nums[i];
                secondNums[i] = nums[n + i];
            }
            var x = 0;
            var y = 0;
            for (var i = 0; i < 2 * n; i++)
            {
                if (i % 2 == 0)
                {
                    nums[i] = firstNums[x];
                    x++;
                }
                else
                {
                    nums[i] = secondNums[y];
                    y++;
                }
            }

            return nums;
        }
    }
}
