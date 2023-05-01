using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sistema_de_parqueo.Modelos;

namespace Sistema_de_parqueo.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Contexto() : base("name=auto") { }
    }
}
