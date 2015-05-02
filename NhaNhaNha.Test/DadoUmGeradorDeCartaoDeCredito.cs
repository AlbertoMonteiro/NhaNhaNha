using System.Text.RegularExpressions;
using NhaNhaNha.Extensions;
using NUnit.Framework;

namespace NhaNhaNha.Test
{
    [TestFixture]
    public class DadoUmGeradorDeCartaoDeCredito
    {
        [Test]
        public void DeveriaGerarUmNúmeroDe16Dígitos()
        {
            string cartao = NhaNhaNha.CartaoCredito;
            Assert.AreEqual(16, cartao.Length);
        }

        [Test]
        public void DeveriaGerarNúmerosVálidos()
        {
            string cartao = NhaNhaNha.CartaoCredito;
            Assert.IsTrue(cartao.CartaoCreditoValido());
        }

        [Test]
        public void DeveriaGerarUmNúmeroDeCartãoNoFormatoXXXX_XXXX_XXXX_XXXX()
        {
            string cartao = NhaNhaNha.CartaoCredito.Formatado;
            StringAssert.IsMatch(@"(\d{4} ){3}\d{4}", cartao);
        }
    }
}