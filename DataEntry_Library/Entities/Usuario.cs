using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Usuario
    {
        public virtual int id { get; set; }
        public virtual string username { get; set; }
        public virtual string password_hash { get; set; }
        public virtual string password_reset_token { get; set; }
        public virtual string email { get; set; }
        public virtual string auth_key { get; set; }
        public virtual int role { get; set; }
        public virtual int status { get; set; }
        public virtual int user_type { get; set; }

        public virtual DateTime created_at { get; set; }
        public virtual DateTime updated_at { get; set; }

        public virtual string password { get; set; }
        

    }
}
