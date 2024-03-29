﻿using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class DeporteMap : ClassMap<Deporte>
    {
        public DeporteMap()
        {
            Table("deporte");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            Map(c => c.Activo)
                .Default("1");
            HasManyToMany<Empleado>(c => c.EmpleadosDeportistas)
                .Cascade.All()
                .Inverse()
                .Table("deporte_empleado");
        }
    }
}
