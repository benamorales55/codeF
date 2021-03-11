using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst2.Models
{
    public class UniversidadContext: DbContext
    {
        public UniversidadContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Universidad> Universidads { get; set; }
    }
}