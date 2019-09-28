namespace ManangerAPI.Application.Contratos
{
    public interface IMailApplication 
    {
         void EnviarEmailAnalise(bool Aprovado, string para, string nome);

         void EnviarEmailSolicitacaoContrato(string contratante,string para, string nome);
         
         void EnviarEmailRespostaSolicitacaoContrato(string prestadodDeServico,string para, string nome);

         void EnviarEmailRecuperarSenha(string para, string nome, string usuario, string senha);
         
    }
}