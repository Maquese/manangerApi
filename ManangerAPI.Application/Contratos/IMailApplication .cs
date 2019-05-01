namespace ManangerAPI.Application.Contratos
{
    public interface IMailApplication 
    {
         void EnviarEmailAnalise(bool Aprovado, string para);
    }
}