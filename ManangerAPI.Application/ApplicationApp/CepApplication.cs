using System.Net.Http;
using System.Threading.Tasks;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using Newtonsoft.Json;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : ICepApplication
    {
        public async Task<EnderecoCepDTO> BuscarEnderecoPorCepAsync(string cep)
        {
            var url = "https://viacep.com.br/ws/"+cep+"/json/";
            var retorno = new EnderecoCepDTO();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await  response.Content.ReadAsStringAsync();

            var deserialized = JsonConvert.DeserializeObject<CepResultDTO>(responseBody);

            retorno.Cep = deserialized.cep;
            retorno.Bairro = deserialized.bairro;
            retorno.Complemento = deserialized.complemento;
            retorno.Rua = deserialized.logradouro;
            retorno.Uf = deserialized.uf;
            retorno.IdCidade = _cidadeRepositorio.EncotrarIdPorNome(deserialized.localidade);
            return retorno;
        }
    }
}