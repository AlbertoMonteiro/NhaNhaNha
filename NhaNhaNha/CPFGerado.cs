namespace NhaNhaNha
{
    public class CPFGerado : DocumentoGerado
    {
        public string Cpf { get { return valor; } }

        public CPFGerado(string cpf)
            : base(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})", "$1.$2.$3-$4")
        {
        }
    }
}