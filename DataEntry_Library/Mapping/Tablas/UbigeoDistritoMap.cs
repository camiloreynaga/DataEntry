using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class UbigeoDistritoMap : ClassMap<UbigeoDistrito>
    {
        public UbigeoDistritoMap()
        {
            Table("ubigeo_distrito");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            References(c => c.Provincia);
            Map(c => c.Activo)
                 .Default("1");
            
        }
    }
}
