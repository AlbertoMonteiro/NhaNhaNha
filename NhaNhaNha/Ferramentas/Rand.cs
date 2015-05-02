using System;

namespace NhaNhaNha.Ferramentas
{
    internal static class Rand
    {
        private static readonly Random random;

        static Rand()
        {
            random = new Random();
        }

        public static int Next(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}