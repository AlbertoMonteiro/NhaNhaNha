using System.Text.RegularExpressions;
using NhaNhaNha.Extensions;
using NUnit.Framework;

namespace NhaNhaNha.Test
{
    [TestFixture]
    public class DadoUmGeradorDeDocumento
    {
        [Test]
        public void AoGerarCpfResultadoDeveConter11Digitos()
        {
            var cpf = NhaNhaNha.CPF.Cpf;
            Assert.AreEqual(11, cpf.Length);
        }

        [Test]
        public void AoGerarCpfResultadoDeveSerUmCpfValido()
        {
            string cpf = NhaNhaNha.CPF;
            Assert.IsTrue(cpf.CpfValido());
        }

        [Test]
        public void AoGerarCpfResultadoDeveDeveConterUmFormatoEspecifico()
        {
            var cpf = NhaNhaNha.CPFFormatado;
            Assert.IsTrue(Regex.IsMatch(cpf, @"\d{3}\.\d{3}\.\d{3}-\d{2}"));
        }

        [Test]
        public void AoGerarCnpjResultadoDeveConter11Digitos()
        {
            var cnpj = NhaNhaNha.Cnpj.Cnpj;
            Assert.AreEqual(14, cnpj.Length);
        }

        [Test]
        public void AoGerarCnpjResultadoDeveSerUmCpfValido()
        {
            string cnpj = NhaNhaNha.Cnpj;
            Assert.IsTrue(cnpj.CNPJValido());
        }

        [Test]
        public void AoGerarCnpjResultadoDeveDeveConterUmFormatoEspecifico()
        {
            var cnpj = NhaNhaNha.CnpjFormatado;
            Assert.IsTrue(Regex.IsMatch(cnpj, @"\d{1}\.\d{3}\.\d{3}/0001-\d{2}"));
        }

    }
}
