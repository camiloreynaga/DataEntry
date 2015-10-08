using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class EmpleadoMap : SubclassMap<Empleado>
    {
        public EmpleadoMap()
        {
            Map(c => c.CodigoPlanilla);
            Map(c => c.CarnetExtranjeria);
            Map(c => c.GrupoSanguineo);
            Map(c => c.Ruc);
            Map(c => c.LibretaMilitar);
            Map(c => c.Discapacidad);
            Map(c => c.DocIdentDiscapacidad);
            Map(c => c.NroResolucionEjecutiva);
            Map(c => c.Enfermedad);
            HasMany(c => c.Deportes);
            HasMany(c => c.Pasatiempos);
            References(c => c.TipoVivienda);
            References(c => c.EstadoCivil);
            Map(c => c.TieneHijos);
            Map(c => c.NroPersonasDependientes);
            Map(c => c.TieneConyuge);
            HasMany(c => c.Parientes);
            HasMany(c => c.ContactosEmergencia);
            HasMany(c => c.DatosLaborales);
            HasMany(c => c.FormacionAcademica);
            HasMany(c => c.Capacitaciones);
            HasMany(c => c.Idiomas);
            HasMany(c => c.Ofimatica);
            HasMany(c => c.ExperienciasLaborales);


        }
    }
}
