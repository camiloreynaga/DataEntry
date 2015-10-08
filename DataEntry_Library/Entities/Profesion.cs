using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Profesion: FormacionAcademica
    {
        public virtual string ProfesionEspecialidad { get; set; }
        /// <summary>
        /// indica si es de nivel univeersitario o tecnico
        /// </summary>
        public virtual bool Universitario{get;set;}
        public virtual bool Titulado {get;set;}
        public virtual string NroColegiatura { get; set; }
    }
}
