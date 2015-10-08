using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class PersonaMap : ClassMap<Persona>
    {
        public PersonaMap()
        {
            Id(c => c.Id);
            Map(c => c.Nombre);
            Map(c => c.ApellidoPaterno);
            Map(c => c.ApellidoMaterno);
            References(c => c.TipoDocumento);
            Map(c => c.NumeroDocumento);
            Map(c => c.FechaNacimiento);
            Map(c => c.Sexo);
            HasMany(c => c.Domicilio);
            Map(c => c.TelefonoCasa);
            Map(c => c.Celular);
            Map(c => c.Celular2);
            Map(c => c.CorreoElectronico);
            Map(c => c.CorreoElectronico2);

        }
    }
}
