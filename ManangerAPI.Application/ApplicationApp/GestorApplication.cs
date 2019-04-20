using System;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IGestorApplication
    {
        /// <summary>
        /// Cadastra os novos gestores 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <param name="email"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="comentarios"></param>
        /// <param name="termos"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="bairro"></param>
        /// <param name="cep"></param>
        /// <param name="rua"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="historicoProfissional"></param>
        /// <param name="certificacoes"></param>
        public void Cadastrar(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, 
                              string telefone, string comentarios, bool termos, string cidade, string estado, string bairro, string cep, 
                              string rua, string numero, string complemento, string historicoProfissional, string certificacoes)
        {
            Gestor gestor = new Gestor
            {
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Cpf = cpf,
                Telefone = telefone,
                Comentario = comentarios,
                Termos = termos,
                CursosCertificacoes = certificacoes,
                HistoricoProfissional = historicoProfissional,
                Sexo = sexo,
                Status = 0,
                Endereco = new Endereco{
                    Estado = estado,
                    Cidade = cidade,
                    Bairro = bairro,
                    Rua = rua,
                    Numero = numero,
                    Cep = cep,
                    Complemento = complemento,
                    Status = 0
                }
            };
            _gestorRepositorio.Insert(gestor);
            _gestorRepositorio.Save();
        }
    }
}