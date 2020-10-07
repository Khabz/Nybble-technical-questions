using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "TO BE OR NOT TO BE";
            var output = printVertically(s);

            using JsonDocument doc = JsonDocument.Parse(JsonSerializer.Serialize(output));
            JsonElement root = doc.RootElement;

            Console.WriteLine(root);
            Console.ReadLine();
        }

        static IList<string> printVertically(string s)
        {
            List<string> res = new List<string>();
            string[] arr = s.Split(' ');
            int max = 0, index = 0;

            foreach (string str in arr) max = Math.Max(max, str.Length);
            for (int i = 0; i < max; i++)
            {
                StringBuilder vertical = new StringBuilder();
                foreach (string str in arr)
                {
                    vertical.Append(index >= str.Length ? ' ' : str[index]);
                }

                res.Add(vertical.ToString().TrimEnd());
                index++;
            }
            return res;
        }
    }
}
