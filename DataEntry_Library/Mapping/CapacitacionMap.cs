using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class CapacitacionMap : ClassMap<Capacitacion>
    {
        public CapacitacionMap()
        {
            Table("capacitacion");
            Id(c => c.Id);
            Map(c => c.Descripcion);
            Map(c => c.Activo)
                .Default("1");
            HasManyToMany<CapacitacionEmpleado>(x => x.EmpleadoCapacitados)
                .Cascade.All()
                .Inverse()
                .Component(c =>{
                    c.Map(x => x.Tiempo);
                    c.Map(x => x.Horas);
                    c.References<Empleado>(r => r.Empleados,"Empleado_id");

                    })
                .Table("capacitacion_empleado");

        }
    }
}
