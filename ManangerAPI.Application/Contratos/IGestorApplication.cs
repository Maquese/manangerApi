using System;

namespace ManangerAPI.Application.Contratos
{
    public interface IGestorApplication
    {
         void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,string cidade,string estado,string bairro,string cep,
                        string rua,string numero,string complemento, string historicoProfissional, string certificacoes);
    }
}