using System;
using System.Text.Json;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 3, 1, 2, 10, 1 };
            var output = RunningSum(input);

            using JsonDocument doc = JsonDocument.Parse(JsonSerializer.Serialize(output));
            JsonElement root = doc.RootElement;
            Console.WriteLine(root);
            Console.ReadLine();
        }

        static int[] RunningSum(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] += numbers[i - 1];
            }
            return numbers;
        }
    }
}
