using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NhaNhaNha.Ferramentas;

namespace NhaNhaNha.Extensions
{
    public static class Extensions
    {
        public static bool CpfValido(this string cpf)
        {
            return cpf.Length == 11 && Mod11(cpf, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2);
        }

        public static bool CNPJValido(this string cnpj)
        {
            return cnpj.Length == 14 && Mod11(cnpj, 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2);
        }

        public static bool Mod11(this string cpf, params int[] multiplicadores)
        {
            var cpfDigits = cpf.Select(char.GetNumericValue).ToList();

            var rest = cpfDigits.Zip(multiplicadores.Skip(1), (cpfDigit, mult) => cpfDigit * mult).Sum() % 11;

            cpfDigits.Add(rest < 2 ? 0 : 11 - rest);
            rest = cpfDigits.Zip(multiplicadores, (cpfDigit, mult) => cpfDigit * mult).Sum() % 11;

            return cpf.EndsWith((rest < 2 ? 0 : 11 - rest).ToString());
        }

        public static IEnumerable<int> Mod11(this List<int> digits, params int[] multiplicadores)
        {
            var rest = digits.Zip(multiplicadores.Skip(1), (cpfDigit, mult) => cpfDigit * mult).Sum() % 11;

            digits.Add(rest < 2 ? 0 : 11 - rest);
            rest = digits.Zip(multiplicadores, (cpfDigit, mult) => cpfDigit * mult).Sum() % 11;

            return digits.Concat(new[] { rest < 2 ? 0 : 11 - rest });
        }

        public static bool CartaoCreditoValido(this string cartao)
        {
            var sum = cartao.Select((a,d) =>
            {
                int n;
                if (d % 2 == 0)
                    n = (int)char.GetNumericValue(a);
                else
                {
                    n = (int)char.GetNumericValue(cartao[d - 1]) * 2;
                    if (n >= 10)
                        n -= 9;
                }
                return n;
            }).Sum();
            return sum % 10 == 0;
        }


        public static string Sample(this string[] strings)
        {
            var index = Rand.Next(strings.Length - 1);
            return strings[index];
        }

        public static string Captalize(this string str)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str);
        }

        public static IEnumerable<int> To(this int a, int b)
        {
            return a > b ? Enumerable.Range(b, a).Reverse() : Enumerable.Range(a, b);
        }

    }
}
