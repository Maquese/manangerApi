using System;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IPrestadorDeServicoApplication
    {
        public void Cadastrar(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, 
                              string telefone, string cidade, string estado, string bairro, string cep, string rua, string numero, 
                              string complemento, string competencias, string comentario, bool termos)
        {
            PrestadorDeServico prestadorServico = new PrestadorDeServico{
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Cpf = cpf,
                Telefone = telefone,
                Status = 0,
                Competencias = competencias,
                Comentario = comentario,
                Termos = termos,
                Endereco = new Endereco
                {
                    Estado = estado,
                    Cidade = cidade,
                    Bairro = bairro,
                    Rua = rua,
                    Numero = numero,
                    Complemento = complemento,
                    Status = 0,
                    Cep = cep
                }
            };
            _prestadorDeServicoRepositorio.Insert(prestadorServico);
            _prestadorDeServicoRepositorio.Save();
        }
    }
}