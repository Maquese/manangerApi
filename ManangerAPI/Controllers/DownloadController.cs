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
        public IActionResult  BaixarCurriculoPorUsuario(int id)
        {
            var dados = new MemoryStream(_downloadApplication.BaixarCurriculoPorUsuario(id));
            return File(dados, "application/pdf", "curriculo.pdf");
            //return  new FileStreamResult(new MemoryStream(dados),"application/pdf");

            // response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            // response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            // response.Content.Headers.ContentDisposition.FileName = "curriculo"+ ".pdf";
            // return response;
        }


    }
}