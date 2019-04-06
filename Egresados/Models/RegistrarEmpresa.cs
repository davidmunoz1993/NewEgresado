using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class RegistrarEmpresa
    {

        [Key]
        public int RegistrarEmpresaID { get; set; }
        public string NombreEmpresa { get; set; }
        public char Correo { get; set; }
        public int Nit { get; set; }
        public string DireccionEmpresa { get; set; }
        public int NumeroEgresado { get; set; }
        public string DescripccionEmpresa { get; set; }
        public char fotoEmpresa { get; set; }
    }
}