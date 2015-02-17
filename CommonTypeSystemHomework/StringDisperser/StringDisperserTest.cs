using System;

namespace StringDisperser
{
    class StringDisperserTest
    {
        static void Main(string[] args)
        {
            var stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
