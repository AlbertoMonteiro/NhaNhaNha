namespace NhaNhaNha
{
    public class CNPJGerado : DocumentoGerado
    {
        public string Cnpj { get { return valor; } }

        public CNPJGerado(string cnpj)
            : base(cnpj, @"(\d{2})(\d{3})(\d{3})0001(\d{2})", "$1.$2.$3/0001-$4")
        {
        }
    }
}