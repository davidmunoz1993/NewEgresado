using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class ReferenciasPersonales
    {
        [Key]
        [Display(Name = "Referenvias id")]
        public int referenciasPersonalesID { get; set; }

        [Display(Name = "Nombres")]
        public String NombresReferencia { get; set; }

        [Display(Name = "Primer apeliido")]
        [Required ]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se aceptan letras en este campo")]
        public String PrimerApellidoReferencia { get; set; }

        [Display(Name = " Segundo apellido")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se aceptan letras en este campo")]
        public String SegundoApellidoReferencia { get; set; }

        [Display(Name = "Cargo que ocupa")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se aceptan letras en este campo")]
        public String CargoReferencia { get; set; }

        [Display(Name = "Teléfono ")]
        public String TelefonoFijoReferencia { get; set; }

        [Display(Name = "Extención")]
        public String ExtTelefonoReferencia { get; set; }

        [Display(Name = "Teléfono móvil")]
        public String TelefonoMovilReferencia { get; set; }

        public int InformacionPersonalEgresadoID { get; set; }
        public virtual ReferenciasPersonales Referencias { get; set; }


    }
}