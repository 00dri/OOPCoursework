using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentsByGroup
{
    public static class Extensions
    {
        public static string ListToString(this IList<int> list)
        {
            var listAsString = string.Join(", ", list.Select(i => i.ToString(CultureInfo.InvariantCulture)));
            return listAsString;
        }

        public static void PrintEach<T>(this IEnumerable<T> obj)
        {
            foreach (var member in obj)
            {
                Console.WriteLine(member);
            }
        }
    }
}
