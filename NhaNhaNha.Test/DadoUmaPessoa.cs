using System.Linq;
using NUnit.Framework;

namespace NhaNhaNha.Test
{
    [TestFixture]
    public class DadoUmaPessoa
    {
        [Test]
        public void UmaPessoaDeveTerPreenchidoPrimeiroNomeComUmaStringNaoVazia()
        {
            var pessoa = new Pessoa(Sexo.Homen);

            Assert.IsFalse(string.IsNullOrWhiteSpace(pessoa.PrimeiroNome));
        }

        [Test]
        public void UmaPessoaDeveTerPreenchidoSobreNomeComUmaStringNaoVazia()
        {
            var pessoa = NhaNhaNha.Homen;

            Assert.IsFalse(string.IsNullOrWhiteSpace(pessoa.SobreNome));
        }

        [Test]
        public void UmaPessoaDeveTerPeloMenos2SobreNomes()
        {
            var pessoa = NhaNhaNha.Homen;

            Assert.GreaterOrEqual(pessoa.SobreNome.Split(' ').Length, 2);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaCriancaDeveTerEntreZeroEOnzeAnos()
        {
            var pessoa = NhaNhaNha.Pessoa(Sexo.Homen, FaixaEtaria.Crianca);

            Assert.GreaterOrEqual(pessoa.Idade, 0);
            Assert.LessOrEqual(pessoa.Idade, 11);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaAdolescenteDeveTerEntreDozeEDezoitoAnos()
        {
            var pessoa = NhaNhaNha.Pessoa(Sexo.Homen, FaixaEtaria.Adolescente);

            Assert.GreaterOrEqual(pessoa.Idade, 12);
            Assert.LessOrEqual(pessoa.Idade, 18);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaAdultoDeveTerEntreDezenoveESessentaAnos()
        {
            var pessoa = NhaNhaNha.Pessoa(Sexo.Homen, FaixaEtaria.Adulto);

            Assert.GreaterOrEqual(pessoa.Idade, 19);
            Assert.LessOrEqual(pessoa.Idade, 60);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaIdosoDeveTerEntreSessentaEUmECentoETrintaAnos()
        {
            var pessoa = NhaNhaNha.Pessoa(Sexo.Homen, FaixaEtaria.Idoso);

            Assert.GreaterOrEqual(pessoa.Idade, 61);
            Assert.LessOrEqual(pessoa.Idade, 130);
        }

        [Test]
        public void GeracaoDePessoasPeloEnumerableRangeDevemSerDiferentes()
        {
            var homens = Enumerable.Range(1, 20).Select(x => NhaNhaNha.Homen).ToList();

            var homen = homens.First();

            foreach (var pessoa in homens.Skip(1))
            {
                Assert.AreNotEqual(homen.PrimeiroNome,pessoa.PrimeiroNome);
                homen = pessoa;
            }
        }
    }
}
