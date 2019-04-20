using System;
using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratanteApplication
    {
        public void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,string cidade,string estado,string bairro,string cep,
                        string numero,string complemento, string rua)
        {
            Contratante contratante = new Contratante
            {   
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Cpf = cpf,
                Telefone = telefone,
                Comentario = comentarios,
                Termos = termos,
                Status = 0,
                Endereco = new Endereco 
                {
                    Estado = estado,
                    Cidade = cidade,
                    Bairro = bairro,
                    Cep = cep,
                    Numero = numero,
                    Complemento = complemento,
                    Rua = rua,
                    Status = 0
                }
            };
            _contratanteRepositorio.Insert(contratante);
            _contratanteRepositorio.Save();
        }

        public ContratanteDTO DetalharContratante(int idContratante)
        {
            throw new System.NotImplementedException();
        }

        public IList<ContratanteDTO> ListarContratantes(bool analisado)
        {
            throw new System.NotImplementedException();
        }
    }
}