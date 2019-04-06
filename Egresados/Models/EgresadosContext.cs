using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Egresados.Models
{
    public class EgresadosContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EgresadosContext() : base("name=EgresadosContext")
        {
        }

        public System.Data.Entity.DbSet<Egresados.Models.AgregarOferta> AgregarOfertas { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.RegistrarEmpresa> RegistrarEmpresas { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.Administrador> Administradors { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.PublicacionAdmin> PublicacionAdmins { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.PublicacionesEnEspera> PublicacionesEnEsperas { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.InformacionPersonalEgresado> InformacionPersonalEgresadoes { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.ReferenciasPersonales> ReferenciasPersonales { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.InformacionLaboral> InformacionLaborals { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.InformacionProfesional> InformacionProfesionals { get; set; }

        public System.Data.Entity.DbSet<Egresados.Models.ConsultarOfertaEmpresa> ConsultarOfertaEmpresas { get; set; }
    }
}
