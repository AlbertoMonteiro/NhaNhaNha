using System;
using System.Linq;

namespace NhaNhaNha
{
    internal class Utils
    {
        public static T SortearPorPeso<T>(ConfiguracaoSorteio<T>[] configuracoes)
        {
            var somaProbabilidade = configuracoes.Sum(conf => conf.Probabilidade);
            if (somaProbabilidade != 100)
                throw new ArgumentException("Somatório de pesos deve ser igual a 100");

            var c = 1;
            var prob = Rand.Next(100);

            return configuracoes.First(conf => c.To((c += conf.Probabilidade) - 1).Contains(prob)).Valores;
        }
    }
}