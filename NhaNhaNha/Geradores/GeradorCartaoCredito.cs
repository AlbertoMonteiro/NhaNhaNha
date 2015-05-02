using System;
using System.Collections.Generic;
using System.Linq;
using NhaNhaNha.Extensions;
using NhaNhaNha.Ferramentas;
using NhaNhaNha.Modelos;

namespace NhaNhaNha.Geradores
{
    public class GeradorCartaoCredito : IGerador<CartaoCreditoGerado, CartaoCreditoConfiguracao>
    {
        private const int CODIGO_AMEX = 3;
        private const int CODIGO_VISA = 4;
        private const int CODIGO_MASTER = 5;

        public CartaoCreditoGerado Gera(CartaoCreditoConfiguracao configuracao = null)
        {
            var numeros = new List<int>();

            numeros.AddRange(new[] { /*CODIGO_AMEX, */CODIGO_VISA/*, CODIGO_MASTER */});

            numeros.AddRange(1.To(16 - numeros.Count).Select(i => Rand.Next(9)));

            int totalPares = 0;
            var numerosVerificacao = numeros.Select((p, i) =>
            {
                int n = 0;
                if (i % 2 == 0)
                {
                    n = p;
                    totalPares += n;
                }
                else
                {
                    n = numeros[i - 1] * 2;
                    if (n >= 10) n -= 9;
                }

                return n;
            }).ToList();

            var total = numerosVerificacao.Sum();
            var resto = total % 10;

            resto = Math.Min(Math.Abs(10 - resto), resto);

            if (resto > 0)
            {
                while (resto != 0)
                {
                    for (int i = 1; i < 16; i++)
                    {
                        if (resto == 0) break;
                        if (i % 2 == 0) continue;

                        var p = i - 1;
                        var numero = numeros[p];

                        var n2 = numero * 2;
                        if (n2 >= 10) n2 -= 9;

                        if (numeros[p] < 5)
                            numeros[p] += 1;
                        if (numero != numeros[p])
                        {
                            var n3 = numeros[p] * 2;
                            if (n3 >= 10) n3 -= 9;
                            resto -= n3 - n2+1;
                        }
                    }
                }
            }
            return new CartaoCreditoGerado(string.Join("", numeros));
        }
    }

    public class CartaoCreditoConfiguracao
    {
    }
}