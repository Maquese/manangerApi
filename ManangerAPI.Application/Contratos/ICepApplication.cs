using System.Threading.Tasks;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public  interface ICepApplication
    {
          Task<EnderecoCepDTO>  BuscarEnderecoPorCepAsync(string cep);
          
    }
}