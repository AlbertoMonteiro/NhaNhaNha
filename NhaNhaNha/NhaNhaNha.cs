namespace NhaNhaNha
{
    public class NhaNhaNha
    {
        public static Pessoa Homen
        {
            get
            {
                return new Pessoa(Sexo.Homen);
            }
        }

        public static Pessoa Mulher
        {
            get
            {
                return new Pessoa(Sexo.Mulher);
            }
        }

        public static Pessoa Pessoa(Sexo sexo = Sexo.Homen, FaixaEtaria faixaEtaria = FaixaEtaria.Adulto)
        {
            return new Pessoa(sexo, faixaEtaria);
        }
    }
}