using NhaNhaNha.Modelos;
using NUnit.Framework;

namespace NhaNhaNha.Test
{
    [TestFixture]
    public class DadoUmaPessoa
    {
        [TestCase(Sexo.Homen)]
        [TestCase(Sexo.Mulher)]
        public void UmaPessoaDeveTerPreenchidoPrimeiroNomeComUmaStringNaoVazia(Sexo sexo)
        {
            var pessoa = NhaNhaNha.Pessoa(sexo);

            Assert.IsFalse(string.IsNullOrWhiteSpace(pessoa.PrimeiroNome));
        }

        [TestCase(Sexo.Homen)]
        [TestCase(Sexo.Mulher)]
        public void UmaPessoaDeveTerPreenchidoSobreNomeComUmaStringNaoVazia(Sexo sexo)
        {
            var pessoa = sexo == Sexo.Homen ? NhaNhaNha.Homen : NhaNhaNha.Mulher;

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
    }
}
