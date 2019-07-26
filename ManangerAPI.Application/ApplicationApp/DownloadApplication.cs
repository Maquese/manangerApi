using System;
using ManangerAPI.Application.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IDownloadApplication
    {
        public byte[] BaixarCurriculoPorUsuario(int idUsuario)
        {
            return   Convert.FromBase64String(_usuarioRepositorio.Encontrar(idUsuario).Curriculo);
        }
    }
}