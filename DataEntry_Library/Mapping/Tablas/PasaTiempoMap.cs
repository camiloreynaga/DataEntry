using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class PasaTiempoMap : ClassMap<Pasatiempo>
    {
        public PasaTiempoMap()
        {
            Table("pasatiempo");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            Map(c => c.Activo)
                .Default("1");
            HasManyToMany<Empleado>(c => c.EmpleadosPasatiempos)
                .Cascade.All()
                .Inverse()
                .Table("pasatiempo_empleado");
        }
    }
}
