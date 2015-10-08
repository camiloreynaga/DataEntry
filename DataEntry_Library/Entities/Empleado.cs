using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class Empleado : Persona
    {
        public virtual string CodigoPlanilla { get; set; }
        /// <summary>
        /// Nro de carnet de extranjeria
        /// </summary>
        public virtual string CarnetExtranjeria { get; set; }
        /// <summary>
        /// Grupo sanguineo al que pertenece
        /// </summary>
        public virtual string GrupoSanguineo { get; set; }

        

        /// <summary>
        /// Nro de RUC
        /// </summary>
        public virtual string Ruc { get; set; }
        /// <summary>
        /// Nro de libreta Militar
        /// </summary>
        public virtual string LibretaMilitar { get; set; }

        #region Discapacidad
        /// <summary>
        /// tiene alguna discapacidad si / no
        /// </summary>
        public virtual bool Discapacidad { get; set; }
        public virtual string DocIdentDiscapacidad { get; set; }
        /// <summary>
        /// Nro de resolucion ejecutiva para la discapacidad
        /// </summary>
        public virtual string NroResolucionEjecutiva { get; set; }
        #endregion

        /// <summary>
        /// enfermedades que se deban indicar para su atencion oportuna
        /// </summary>
        public virtual string Enfermedad { get; set; }

        /// <summary>
        /// deportes que practica
        /// </summary>
        public virtual IList<Deporte> Deportes { get; set; }

        /// <summary>
        /// pasatiempos que practica
        /// </summary>
        public virtual IList<Pasatiempo> Pasatiempos { get; set; }

        
        /// <summary>
        /// tipo de vivienda que en la que habita
        /// </summary>
        public virtual TipoVivienda TipoVivienda { get; set; }

        /// <summary>
        /// estado civil actual
        /// </summary>
        public virtual EstadoCivil EstadoCivil { get; set; }
        /// <summary>
        /// Indica si el empleado tiene hijos Si / no
        /// </summary>
        public virtual bool TieneHijos { get; set; }

        /// <summary>
        /// Nro de personas que dependen economicamente del empleado
        /// </summary>
        public virtual int NroPersonasDependientes { get; set; }

        /// <summary>
        /// indica que tiene un cónyuge
        /// </summary>
        public virtual bool TieneConyuge { get; set; }

        /// <summary>
        /// Hijos, Conyuge, Padres y demas
        /// </summary>
        public virtual IList<Pariente> Parientes { get; set; }

        /// <summary>
        /// lista de contactos de emergencia
        /// </summary>
        public virtual IList<ContactoEmergencia> ContactosEmergencia { get; set; }

        /// <summary>
        /// datos laborales consignados
        /// </summary>
        public virtual IList<DatosLaborales> DatosLaborales { get; set; }

        /// <summary>
        /// datos de formacion academica del empleado
        /// </summary>
        public virtual IList<FormacionAcademica> FormacionAcademica { get; set; }
        /// <summary>
        /// Capacitaciones recibidad en los ultimos 3 anios
        /// </summary>
        public virtual IList<Capacitacion> Capacitaciones { get; set; }

        /// <summary>
        /// Idiomas que has estudiado / domina
        /// </summary>
        public virtual IList<IdiomaHabla> Idiomas { get; set; }

        /// <summary>
        /// Software que ha estudiado domina
        /// </summary>
        public virtual IList<Ofimatica> Ofimatica { get; set; }
        /// <summary>
        /// Datos de experiencia laborales del empleado en essalud y otras empresas
        /// </summary>
        public virtual IList<ExperienciaLaboral> ExperienciasLaborales { get; set; }


    }
}
