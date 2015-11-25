using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class LogMap : ClassMap<Log>
    {
        public LogMap()
        {
            Table("log");
            Id(c => c.Id);
            Map(c => c.Fecha);
            Map(c => c.Tabla);
            Map(c => c.Campo);
            Map(c => c.Usuario);
            Map(c => c.Suceso);
        }
    }
}
