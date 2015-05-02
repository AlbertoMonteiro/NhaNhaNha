using NhaNhaNha.Geradores;
using NhaNhaNha.Modelos;

namespace NhaNhaNha
{
    public static class NhaNhaNha
    {
        private static readonly IGerador<CPFGerado, DocumentoGeracao> geradorCpf;
        private static readonly IGerador<CNPJGerado, DocumentoGeracao> geradorCnpj;
        private static readonly IGerador<PessoaGerada, PessoaConfiguracao> geradorPessoa;
        private static IGerador<CartaoCreditoGerado, CartaoCreditoConfiguracao> geradorCartaoCredito;

        static NhaNhaNha()
        {
            geradorCpf = new GeradorCPF();
            geradorCnpj = new GeradorCNPJ();
            geradorPessoa = new GeradorPessoa();
            geradorCartaoCredito = new GeradorCartaoCredito();
        }
        public static PessoaGerada Homen
        {
            get
            {
                return geradorPessoa.Gera(new PessoaConfiguracao { Sexo = Sexo.Homen });
            }
        }

        public static PessoaGerada Mulher
        {
            get
            {
                return geradorPessoa.Gera(new PessoaConfiguracao { Sexo = Sexo.Mulher });
            }
        }

        public static CPFGerado CPF
        {
            get
            {
                return geradorCpf.Gera();
            }
        }
        
        public static string CPFFormatado
        {
            get
            {
                return geradorCpf.Gera().Formatado;
            }
        }

        public static CNPJGerado Cnpj
        {
            get
            {
                return geradorCnpj.Gera();
            }
        }
        
        public static string CnpjFormatado
        {
            get
            {
                return geradorCnpj.Gera().Formatado;
            }
        }

        public static CartaoCreditoGerado CartaoCredito
        {
            get
            {
                return geradorCartaoCredito.Gera();
            }
        }

        public static PessoaGerada Pessoa(Sexo sexo = Sexo.Homen, FaixaEtaria faixaEtaria = FaixaEtaria.Adulto)
        {
            return geradorPessoa.Gera(new PessoaConfiguracao { Sexo = sexo, FaixaEtaria = faixaEtaria});
        }
    }
}