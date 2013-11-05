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
            var pessoa = new Pessoa(Sexo.Homen);

            Assert.IsFalse(string.IsNullOrWhiteSpace(pessoa.SobreNome));
        }

        [Test]
        public void UmaPessoaDeveTerPeloMenos2SobreNomes()
        {
            var pessoa = new Pessoa(Sexo.Homen);

            Assert.GreaterOrEqual(pessoa.SobreNome.Split(' ').Length, 2);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaCriancaDeveTerEntreZeroEOnzeAnos()
        {
            var pessoa = new Pessoa(Sexo.Homen, FaixaEtaria.Crianca);

            Assert.GreaterOrEqual(pessoa.Idade, 0);
            Assert.LessOrEqual(pessoa.Idade, 11);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaAdolescenteDeveTerEntreDozeEDezoitoAnos()
        {
            var pessoa = new Pessoa(Sexo.Homen, FaixaEtaria.Adolescente);

            Assert.GreaterOrEqual(pessoa.Idade, 12);
            Assert.LessOrEqual(pessoa.Idade, 18);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaAdultoDeveTerEntreDezenoveESessentaAnos()
        {
            var pessoa = new Pessoa(Sexo.Homen, FaixaEtaria.Adulto);

            Assert.GreaterOrEqual(pessoa.Idade, 19);
            Assert.LessOrEqual(pessoa.Idade, 60);
        }

        [Test]
        public void UmaPessoaDeveComFaixaEtariaIdosoDeveTerEntreSessentaEUmECentoETrintaAnos()
        {
            var pessoa = new Pessoa(Sexo.Homen, FaixaEtaria.Idoso);

            Assert.GreaterOrEqual(pessoa.Idade, 61);
            Assert.LessOrEqual(pessoa.Idade, 130);
        }
    }
}
