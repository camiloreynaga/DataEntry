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
            Table("persona");
            Id(c => c.Id);
            Map(c => c.Nombre)
                .CustomType("String")
                .Length(60)
                .Not.Nullable();
            Map(c => c.ApellidoPaterno)
                .CustomType("String")
                .Length(30)
                .Not.Nullable();
            Map(c => c.ApellidoMaterno)
                .CustomType("String")
                .Length(30);
            References(c => c.TipoDocumento);
            Map(c => c.NumeroDocumento)
                .Unique();
            Map(c => c.FechaNacimiento);
            Map(c => c.Sexo)
                .CustomType("Int32")
                .Length(1)
                .Not.Nullable();
            HasMany(c => c.Domicilio);
            Map(c => c.TelefonoCasa)
                .CustomType("Int32")
                .Length(13);
            Map(c => c.Celular)
                .CustomType("Int32")
                .Length(13);
            Map(c => c.Celular2)
                .CustomType("Int32")
                .Length(13);
            Map(c => c.CorreoElectronico);
            Map(c => c.CorreoElectronico2);
            Component(c => c.LugarNacimiento);
            Map(c => c.user_id);

        }
    }
}
