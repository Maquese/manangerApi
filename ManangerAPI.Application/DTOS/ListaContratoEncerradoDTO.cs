using System;

namespace ManangerAPI.Application.DTOS
{
    public class ListaContratoEncerradoDTO 
    {
        public int ContratoId { get; set; }
        public int PerfilId { get; set; }
        public int ContratanteId { get; set; }
        public int PrestadorId { get; set; }
        public string NomeBeneficiario { get;  set; }
        public string NomeContratante { get;  set; }
        public string ColaboradorNome { get;  set; }
        public DateTime? Data { get;  set; }
    }
}