using System;
using System.Collections.Generic;
using System.Linq;
using NhaNhaNha.Extensions;
using NhaNhaNha.Ferramentas;
using NhaNhaNha.Modelos;

namespace NhaNhaNha.Geradores
{
    public class GeradorPessoa : IGerador<PessoaGerada, PessoaConfiguracao>
    {
        private static readonly Dictionary<FaixaEtaria, Func<int>> geradoresIdade;

        static GeradorPessoa()
        {
            geradoresIdade = new Dictionary<FaixaEtaria, Func<int>>
            {
                {FaixaEtaria.Crianca, () => Rand.Next(11)},
                {FaixaEtaria.Adolescente, () => Rand.Next(6) + 12},
                {FaixaEtaria.Adulto, () => Rand.Next(41) + 19},
                {FaixaEtaria.Idoso, () => Rand.Next(70) + 60},
            };
        }
        public PessoaGerada Gera(PessoaConfiguracao configuracao)
        {
            var primeiroNome = Valores.Pessoa[configuracao.Sexo.ToString()].Sample().Captalize();
            var sobreNome = GeraSobreNome();
            var idade = GeraIdade(configuracao.FaixaEtaria);
            return new PessoaGerada(primeiroNome, sobreNome, idade, configuracao.Sexo, configuracao.FaixaEtaria);
        }

        private static int GeraIdade(FaixaEtaria faixaEtaria)
        {
            return geradoresIdade[faixaEtaria]();
        }

        private static string GeraSobreNome()
        {
            var quantidadeSobrenomes = Utils.SortearPorPeso(new[]
            {
                new ConfiguracaoSorteio<int> {Probabilidade = 65, Valores = 2},
                new ConfiguracaoSorteio<int> {Probabilidade = 32, Valores = 3},
                new ConfiguracaoSorteio<int> {Probabilidade = 3, Valores = 4}
            });

            var sobreNomeDisponiveis = Valores.Pessoa["Sobrenomes"];
            var sobrenomes = Enumerable.Range(1, 10)
                .Select(i => sobreNomeDisponiveis.Sample())
                .Distinct()
                .Take(quantidadeSobrenomes)
                .ToList();

            return string.Join(" ", sobrenomes).Captalize();
        }

    }

    public class PessoaConfiguracao
    {
        public FaixaEtaria FaixaEtaria { get; set; }
        public Sexo Sexo { get; set; }
    }
}