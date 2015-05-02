
namespace NhaNhaNha.Geradores
{
    public interface IGerador<out T, in TConfiguracao>
        where TConfiguracao : class
    {
        T Gera(TConfiguracao configuracao = null);
    }
}
