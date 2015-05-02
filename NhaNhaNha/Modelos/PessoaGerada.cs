namespace NhaNhaNha.Modelos
{
    public class PessoaGerada
    {
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
        public int Idade { get; private set; }
        public Sexo Sexo { get; private set; }
        public FaixaEtaria FaixaEtaria { get; private set; }

        public PessoaGerada(string primeiroNome, string sobreNome, int idade, Sexo sexo, FaixaEtaria faixaEtaria)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Idade = idade;
            Sexo = sexo;
            FaixaEtaria = faixaEtaria;
        }
    }
}