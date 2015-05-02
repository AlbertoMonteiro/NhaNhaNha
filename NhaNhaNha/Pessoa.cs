using System;
using System.Collections.Generic;

namespace NhaNhaNha
{
    public class Pessoa
    {
        private readonly Sexo sexo;
        private readonly FaixaEtaria faixaEtaria;
        private string primeiroNome;
        private string sobreNome;
        private int idade;

        public Pessoa(Sexo sexo, FaixaEtaria faixaEtaria = FaixaEtaria.Adulto)
        {
            this.sexo = sexo;
            this.faixaEtaria = faixaEtaria;
        }

        public string PrimeiroNome
        {
            get
            {
                if (string.IsNullOrWhiteSpace(primeiroNome))
                    primeiroNome = Valores.Pessoa[sexo.ToString()].Sample().Captalize();
                return primeiroNome;
            }
        }
        public string SobreNome
        {
            get
            {
                if (string.IsNullOrWhiteSpace(sobreNome))
                    sobreNome = GeraSobreNome();
                return sobreNome;
            }
        }

        public int Idade
        {
            get
            {
                if (idade == 0)
                {
                    switch (faixaEtaria)
                    {
                        case FaixaEtaria.Crianca:
                            idade = Rand.Next(11);
                            break;
                        case FaixaEtaria.Adolescente:
                            idade = Rand.Next(6) + 12;
                            break;
                        case FaixaEtaria.Adulto:
                            idade = Rand.Next(41) + 19;
                            break;
                        case FaixaEtaria.Idoso:
                            idade = Rand.Next(70) + 60;
                            break;
                    }
                }
                return idade;
            }
        }

        private static string GeraSobreNome()
        {
            int quantidadeSobrenomes = Utils.SortearPorPeso(new[]
            {
                new ConfiguracaoSorteio<int> {Probabilidade = 65, Valores = 2},
                new ConfiguracaoSorteio<int> {Probabilidade = 32, Valores = 3},
                new ConfiguracaoSorteio<int> {Probabilidade = 3, Valores = 4}
            });

            string[] sobreNomeDisponiveis = Valores.Pessoa["Sobrenomes"];
            var sobrenomes = new List<string>();

            while (sobrenomes.Count < quantidadeSobrenomes)
            {
                string sorteado = sobreNomeDisponiveis.Sample();
                if (!sobrenomes.Contains(sorteado))
                    sobrenomes.Add(sorteado);
            }

            return string.Join(" ", sobrenomes).Captalize();
        }
    }
}