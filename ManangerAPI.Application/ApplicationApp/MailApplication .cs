using System.Net.Mail;
using ManangerAPI.Application.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IMailApplication
    {
        public void EnviarEmailAnalise(bool Aprovado, string para)
        {
            MailMessage m = new MailMessage(new MailAddress(""), new MailAddress(""));
        }
    }
}