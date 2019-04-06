using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class ConsultarOfertaEmpresa
    {
        [Key]
        public int AgregarOfertaID { get; set; }
        [DisplayName("Fecha de inicio")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaInicio { get; set; }

        [DisplayName("Fecha de finalizacion")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaFinal { get; set; }
        [DisplayName("Asunto")]
        public string Asunto { get; set; }
        [DisplayName("Perfil requerido")]
        public string PerfilRequerido { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
    }
}