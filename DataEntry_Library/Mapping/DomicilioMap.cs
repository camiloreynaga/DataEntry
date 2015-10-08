using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class DomicilioMap : ClassMap<Domicilio>
    {
        public DomicilioMap()
        {
            Id(c => c.Id);
            References(c => c.Region);
            References(c => c.Provincia);
            References(c => c.Distrito);
            References(c => c.TipoVia);
            Map(c => c.NombreVia);
            Map(c => c.NumeroVia);
            Map(c => c.Departamento);
            Map(c => c.Interior);
            Map(c => c.Manzana);
            Map(c => c.Lote);
            Map(c => c.Kilometro);
            Map(c => c.Block);
            Map(c => c.Etapa);
            Map(c => c.Referencia);
        }
    }
}
