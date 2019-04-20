using System;

namespace ManangerAPI.Application.Contratos
{
    public interface IPrestadorDeServicoApplication
    {
         void Cadastrar(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, string telefone,
                        string cidade, string estado, string bairro,string cep, string rua, string numero, string complemento, string competencias,
                        string comentario, bool termos );
    }
}