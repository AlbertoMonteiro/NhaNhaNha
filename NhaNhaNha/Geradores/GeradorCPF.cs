using System.Linq;
using NhaNhaNha.Extensions;
using NhaNhaNha.Ferramentas;
using NhaNhaNha.Modelos;

namespace NhaNhaNha.Geradores
{
    public class GeradorCPF : IGerador<CPFGerado, DocumentoGeracao>
    {
        public CPFGerado Gera(DocumentoGeracao d = null)
        {
            var list = 1.To(9).Select(x => Rand.Next(10)).ToList();
            return new CPFGerado(string.Join("", list.Mod11(11, 10, 9, 8, 7, 6, 5, 4, 3, 2)));
        }
    }
}