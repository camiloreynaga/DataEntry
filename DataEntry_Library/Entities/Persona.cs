using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class Persona
    {
        public virtual int Id { get; set; }
        
        public virtual string Nombre { get; set; }
        public virtual string ApellidoPaterno { get; set; } //apellido paterno
        public virtual string ApellidoMaterno { get; set; } //apellido materno

        public virtual TipoDocumentoIdentidad TipoDocumento { get; set; }
        public virtual string NumeroDocumento { get; set; }
       
        
        public virtual DateTime FechaNacimiento { get; set; }

        public virtual LugarNacimiento LugarNacimiento { get; set; }

        /// <summary>
        /// 1: masculino / 2: femenino. Dato obligatorio
        /// </summary>
        public virtual int Sexo { get; set; }

        public virtual IList<Domicilio> Domicilio { get; set; }
        //public virtual Direccion Direccion2 { get; set; }
        public virtual string TelefonoCasa { get; set; }
        public virtual string Celular{get;set;}
        public virtual string Celular2{get;set;}

        public virtual string CorreoElectronico { get; set; }
        public virtual string CorreoElectronico2 { get; set; }

        //id del usuario
        public virtual int user_id { get; set; }
        
    }
}
