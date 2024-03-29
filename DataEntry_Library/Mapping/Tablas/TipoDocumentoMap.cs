﻿using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping.Tablas
{
    public class TipoDocumentoMap : ClassMap<TipoDocumento>
    {
        public TipoDocumentoMap()
        {
            Table("tipo_documento");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
