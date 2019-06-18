using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ManangerAPI.Application.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IMailApplication
    {
        public void EnviarEmailAnalise(bool Aprovado, string para, string nome)
        {
            MailMessage m = new MailMessage(new MailAddress("lcmananger@gmail.com"), new MailAddress(para));
            m.Subject = "Resultado da análise";
            m.Body = Aprovado ? "Olá " + nome + " você foi aprovado use seu login e senha para começar." : "Olá " + nome + " infelizmente você não foi aprovado.";

            using (var smtp = new SmtpClient("smtp.gmail.com",587))
            {                
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential("lcmananger@gmail.com", "lcmananger123");

                // envia o e-mail
               try
                {                 
                smtp.Send(m);      
                }
                catch (System.Exception)
                {
                    
                }
            }

        }

        public void EnviarEmailSolicitacaoContrato(string contratante, string para, string nome)
        {
             MailMessage m = new MailMessage(new MailAddress("lcmananger@gmail.com"), new MailAddress(para));
            m.Subject = "Nova proposta de contrato";
            m.Body =  "Olá parabéns" + nome + " você tem uma nova solicitação de contrato!\n O "+contratante+"está precisando de seus serviços!\n";

            using (var smtp = new SmtpClient("smtp.gmail.com",587))
            {                
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential("lcmananger@gmail.com", "lcmananger123");

                // envia o e-mail
                try
                {                 
                smtp.Send(m);      
                }
                catch (System.Exception)
                {
                    
                }
            }
        }
    }
}