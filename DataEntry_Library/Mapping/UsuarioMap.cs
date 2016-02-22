using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("user");
            Id(c=>c.id);
            Map(c => c.username);

            Map(c=>c.password_hash);
            Map(c=>c.password_reset_token);
            Map(c=>c.email);
            Map(c=>c.auth_key)
                .CustomType("String")
                //.CustomSqlType("varchar")
                .Length(32);
            /* se referencia por value y nopor id en el codigo*/
            Map(c => c.role)
                .Column("role_id");
            Map(c => c.status)
                .Column("status_id");
            Map(c => c.user_type)
                .Column("user_type_id");
            //
            Map(c => c.created_at);
            Map(c => c.updated_at);
            Map(c => c.password);
        }
    }
}
