using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class InformacionProfesional
    {
        [Key]
        public int InformacionProfesionalID { get; set; }

        [Display(Name = "Estudia actualmente?")]
        public Boolean estudiaActualmente { get; set; }

        [Display(Name = "Fecha de terminación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyyy / MM / dd", ApplyFormatInEditMode = true)]
        public DateTime fechaTerminacionProfesional { get; set; }

        [Display(Name = "Duración")]
        public String duracionProfesional { get; set; }

        public int InformacionPersonalEgresadoID { get; set; }
        public virtual InformacionPersonalEgresado InformacionPersonalEgresado { get; set; }
    }
}