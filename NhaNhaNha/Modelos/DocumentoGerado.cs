using System.Text.RegularExpressions;

namespace NhaNhaNha.Modelos
{
    public abstract class DocumentoGerado
    {
        protected readonly string valor;
        private readonly string pattern;
        private readonly string replacement;

        protected DocumentoGerado(string valor, string pattern, string replacement)
        {
            this.valor = valor;
            this.pattern = pattern;
            this.replacement = replacement;
        }

        public string Formatado
        {
            get {
                return Regex.Replace(valor,pattern,replacement);
            }
        }

        public static implicit operator string(DocumentoGerado documentoGerado)
        {
            return documentoGerado.valor;
        }
    }
}