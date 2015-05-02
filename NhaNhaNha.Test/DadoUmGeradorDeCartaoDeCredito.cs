using System.Text.RegularExpressions;
using NhaNhaNha.Extensions;
using NUnit.Framework;

namespace NhaNhaNha.Test
{
    [TestFixture]
    public class DadoUmGeradorDeCartaoDeCredito
    {
        [Test]
        public void DeveriaGerarUmN�meroDe16D�gitos()
        {
            string cartao = NhaNhaNha.CartaoCredito;
            Assert.AreEqual(16, cartao.Length);
        }

        [Test]
        public void DeveriaGerarN�merosV�lidos()
        {
            string cartao = NhaNhaNha.CartaoCredito;
            Assert.IsTrue(cartao.CartaoCreditoValido());
        }

        [Test]
        public void DeveriaGerarUmN�meroDeCart�oNoFormatoXXXX_XXXX_XXXX_XXXX()
        {
            string cartao = NhaNhaNha.CartaoCredito.Formatado;
            StringAssert.IsMatch(@"(\d{4} ){3}\d{4}", cartao);
        }
    }
}