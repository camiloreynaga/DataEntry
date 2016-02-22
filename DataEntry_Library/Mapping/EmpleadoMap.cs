using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using DataEntry_Library.Entities.Tablas;
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
            Table("empleado");
            Map(c => c.CodigoPlanilla)
                .CustomType("Int32")
                .Length(7);
                //.Not.Nullable()
                //.Unique();
            Map(c => c.CarnetExtranjeria)
                .CustomType("String")
                .Length(10);
            Map(c => c.GrupoSanguineo)
                .CustomType("String")
                .Length(3);
            Map(c => c.Ruc)
                .CustomType("String")
                .Length(11);
            Map(c => c.LibretaMilitar);
            Map(c => c.Discapacidad);
            Map(c => c.DocIdentDiscapacidad);
            Map(c => c.NroResolucionEjecutiva);
            Map(c => c.Enfermedad);
            HasManyToMany<Deporte>(c => c.Deportes)
                .Cascade.All()
                .Table("deporte_empleado");
            HasManyToMany<Pasatiempo>(c => c.Pasatiempos)
                .Cascade.All()
                .Table("pasatiempo_empleado");
            References(c => c.TipoVivienda);
            References(c => c.EstadoCivil);
            Map(c => c.TieneHijos);
            Map(c => c.NroPersonasDependientes);
            Map(c => c.TieneConyuge);
            HasMany(c => c.Parientes);
            HasMany(c => c.ContactosEmergencia);
            HasMany(c => c.DatosLaborales);
            HasMany(c => c.FormacionAcademica);
            HasManyToMany<CapacitacionEmpleado>(x => x.Capacitaciones)
                .Cascade.All()
                .Component(c=>{
                    c.Map(x=>x.Tiempo);
                    c.Map(x=>x.Horas);
                    c.Map(x=>x.Creditos);
                    c.References<Capacitacion>(r=>r.Capacitaciones,"Capacitacion_id");
                })
                .Table("capacitacion_empleado");
            HasMany(c => c.Idiomas);
            HasMany(c => c.Ofimatica);
            HasMany(c => c.ExperienciasLaborales);


        }
    }
}
