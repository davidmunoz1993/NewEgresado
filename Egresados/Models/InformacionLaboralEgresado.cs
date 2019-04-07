using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class InformacionLaboralEgresado
    {
        [Key]
        public int InformacionLaboralID { get; set; }

        [Display(Name = "Trabaja actualmente?")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public Boolean trabajaActualmente { get; set; }

        [Display(Name = "Jefe inmediato - Nombres")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String nombresJefeLaboral { get; set; }

        [Display(Name = "Jefe inmediato- Apellido")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String apellidoJefeLaboral { get; set; }

        [Display(Name = "Jefe inmediato- Teléfono")]
        public String telefonoJefeLaboral { get; set; }

        [Display(Name = "Nombre de la empresa")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String nombreEmpresaLaboral { get; set; }

        [Display(Name = "Dirección de la empresa")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String direccionEmpresaLaboral { get; set; }

        [Display(Name = "Cargo ocupación laboral")]
        public String cargoOcupacionLaboral { get; set; }

        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaIngresoLaboral { get; set; }

        [Display(Name = "Fecha de Egreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaEgresoLaboral { get; set; }
    }
}