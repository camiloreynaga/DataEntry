using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Auth_key { get; set; }
        public virtual string Password { get; set; }
        public virtual string PasswordReset { get; set; }
        public virtual string Email { get; set; }

    }
}
