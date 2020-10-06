using System;
using System.Linq;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            var J = "z";
            var S = "ZZ";
            var output = NumJewelsInStones(J, S);

            Console.Write(output);
            Console.ReadLine();
        }
        static int NumJewelsInStones(string J, string S)
        {
            return S.Count(x => J.Contains(x));
        }
    }
}
