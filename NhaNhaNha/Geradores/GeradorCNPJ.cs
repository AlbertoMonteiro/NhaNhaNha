using System.Linq;
using NhaNhaNha.Extensions;
using NhaNhaNha.Ferramentas;
using NhaNhaNha.Modelos;

namespace NhaNhaNha.Geradores
{
    public class GeradorCNPJ : IGerador<CNPJGerado, DocumentoGeracao>
    {
        public CNPJGerado Gera(DocumentoGeracao d = null)
        {
            var list = 1.To(8).Select(x => Rand.Next(10)).Concat(new[] { 0, 0, 0, 1 }).ToList();
            return new CNPJGerado(string.Join("", list.Mod11(6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2)));
        }
    }
}