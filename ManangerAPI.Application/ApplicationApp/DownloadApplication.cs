using System;
using ManangerAPI.Application.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IDownloadApplication
    {
        public byte[] BaixarCurriculoPorUsuario(int idUsuario)
        {
            var x = _usuarioRepositorio.Encontrar(idUsuario).Curriculo;
            return   Convert.FromBase64String(x);
        }
    }
}