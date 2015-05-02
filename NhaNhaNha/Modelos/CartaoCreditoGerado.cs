using System.Text.RegularExpressions;

namespace NhaNhaNha.Modelos
{
    public class CartaoCreditoGerado
    {
        public string Valor { get; private set; }

        public string Formatado
        {
            get { return Regex.Replace(Valor, @"(\d{4})(\d{4})(\d{4})(\d{4})", "$1 $2 $3 $4"); }
        }

        public CartaoCreditoGerado(string valor)
        {
            Valor = valor;
        }

        public static implicit operator string(CartaoCreditoGerado cartaoCreditoGerado)
        {
            return cartaoCreditoGerado.Valor;
        }
    }
}