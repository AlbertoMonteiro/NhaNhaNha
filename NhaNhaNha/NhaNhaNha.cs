using System;
using System.Collections.Generic;
using System.Linq;

namespace NhaNhaNha
{
    public class NhaNhaNha
    {
        public static Pessoa Homen
        {
            get
            {
                return new Pessoa(Sexo.Homen);
            }
        }

        public static Pessoa Mulher
        {
            get
            {
                return new Pessoa(Sexo.Mulher);
            }
        }

        public static CPFGerado CPF
        {
            get
            {
                var numeros = GenerateSequence(1, 9);

                var d1 = CalculateSum(0, 9, i => numeros[i] * (13 - i));

                d1 = CalculateDigit(d1);

                var d2 = CalculateDigit(d1 * 2 + CalculateSum(0, 9, i => numeros[i] * (11 - i)));

                return new CPFGerado(string.Join("", numeros.Concat(new[] { d1, d2 })));
            }
        }

        public static CNPJGerado Cnpj
        {
            get
            {
                var numeros = GenerateSequence(1, 8, new[] { 0, 0, 0, 1 });

                Func<int, int, int> calculator = (n, i) => (n >= i ? n : n + 8);
                Func<int, int> calculator4 = n => calculator(n, 4);
                Func<int, int> calculator5 = n => calculator(n, 5);

                var d1 = CalculateSum(0, 12, i => numeros[i] * (13 - calculator4(i)));

                d1 = CalculateDigit(d1);

                var d2 = CalculateDigit(d1 * 2 + CalculateSum(0, 12, i => numeros[i] * (14 - calculator5(i))));

                numeros.AddRange(new[] { d1, d2 });
                return new CNPJGerado(string.Join("", numeros));
            }
        }

        public static Pessoa Pessoa(Sexo sexo = Sexo.Homen, FaixaEtaria faixaEtaria = FaixaEtaria.Adulto)
        {
            return new Pessoa(sexo, faixaEtaria);
        }

        private static int CalculateDigit(int d1)
        {
            d1 = 11 - (d1 % 11);
            d1 = d1 >= 10 ? 0 : d1;
            return d1;
        }

        private static int CalculateSum(int start, int count, Func<int, int> selector)
        {
            return start.To(count).Select(selector).Sum();
        }

        private static List<int> GenerateSequence(int start, int count, int[] second = null)
        {
            return start.To(count).Select(x => Rand.Next(10)).Concat(second ?? Enumerable.Empty<int>()).ToList();
        }
    }
}