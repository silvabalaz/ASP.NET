using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Metro.Models
{
    public class Ruta
    {
        public int Duljina { get; set; }
        public string Start { get; set; }
        public string Kraj { get; set; }
    }

    public class RutaDBContext : DbContext
    {
        public DbSet<Ruta> Movies { get; set; }
    }

}