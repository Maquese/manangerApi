namespace ManangerAPI.Application.Contratos
{
    public interface IContatoApplication
    {
        int CriarNovo(string nome, string email ,int tipoContato, string observacoes); 
    }
}