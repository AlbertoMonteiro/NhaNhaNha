using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NhaNhaNha
{
    public static class Extensions
    {
        public static string Sample(this string[] strings)
        {
            var index = Rand.Next(strings.Length-1);
            return strings[index];
        }

        public static string Captalize(this string str)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str);
        }

        public static IEnumerable<int> To(this int a, int b)
        {
            var enumerable = Enumerable.Range(a, b);
            if (a < b)
                enumerable = enumerable.Reverse();
            return enumerable;
        }
    }
}