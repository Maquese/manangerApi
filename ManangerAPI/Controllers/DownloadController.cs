using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using ManangerAPI.Application.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly IDownloadApplication _downloadApplication;

        public DownloadController(IDownloadApplication downloadApplication)
        {
            _downloadApplication  = downloadApplication;
        }
        
        [Route("api/download/baixarcurriculoporusuario")]
        [HttpGet]
        public HttpResponseMessage BaixarCurriculoPorUsuario(int id)
        {
            var dados = _downloadApplication.BaixarCurriculoPorUsuario(id);
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            response.Content = new StreamContent(new MemoryStream(dados));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = "curriculo"+ ".pdf";
            return response;
        }
    }
}