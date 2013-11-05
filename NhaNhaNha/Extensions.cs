using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NhaNhaNha
{
    public static class Extensions
    {
        public static string Sample(this string[] strings)
        {
            var random = new Random();

            var index = random.Next(strings.Length-1);
            return strings[index];
        }

        public static string Captalize(this string str)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str);
        }

        public static IEnumerable<int> To(this int a, int b)
        {
            return Enumerable.Range(a, b);
        }
    }
}