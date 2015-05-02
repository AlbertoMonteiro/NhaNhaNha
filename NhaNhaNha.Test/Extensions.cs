using System.Linq;

namespace NhaNhaNha.Test
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

    }
}
