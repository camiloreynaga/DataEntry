using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class DatosLaborales
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// condicional laboral actual
        /// </summary>
        public virtual CondicionLaboral CondicionLaboral { get; set; }

        /// <summary>
        /// situación del cargo actual
        /// </summary>
        public virtual SituacionCargo SituacionCargo { get; set; }

        /// <summary>
        /// grupo ocupacional al que pertenece
        /// </summary>
        public virtual LineaCarrera LineaCarrera { get; set; }

        /// <summary>
        /// nivel, escala actual, por años de experiencia
        /// </summary>
        public virtual string Nivel { get; set; }
        /// <summary>
        /// cargo actual
        /// </summary>
        public virtual Cargo Cargo { get; set; }
        /// <summary>
        /// fecha de ingreso a la institución
        /// </summary>
        public virtual DateTime FechaIngreso { get; set; }
        /// <summary>
        /// dependencia a la que pertenece o en la que labora
        /// </summary>
        public virtual Dependencia Dependencia { get; set; }

        /// <summary>
        /// indica si pertenece al SNP o a una SPP(afp)
        /// </summary>
        public virtual bool RegimenPensiones { get; set; }
        /// <summary>
        /// fondo privado de pensión al que aporta actualmente
        /// </summary>
        public virtual string Afp { get; set; }
        /// <summary>
        /// código de afp actual
        /// </summary>
        public virtual string NroAfiliado { get; set; }

        /// <summary>
        /// percibe pension actualmente
        /// </summary>
        public virtual bool Pension { get; set; }


        public virtual string Concepto { get; set; }

        /// <summary>
        /// funciones que realiza en el cargo o trabajo actual
        /// </summary>
        public virtual string Funciones { get; set; }

    }
}
