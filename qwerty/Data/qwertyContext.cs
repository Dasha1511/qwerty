using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school.models;

namespace qwerty.Data
{
    public class qwertyContext : DbContext
    {
        public qwertyContext (DbContextOptions<qwertyContext> options)
            : base(options)
        {
        }

        public DbSet<school.models.Class> Class { get; set; }

        public DbSet<school.models.Dolznost> Dolznost { get; set; }

        public DbSet<school.models.predmet> predmet { get; set; }

        public DbSet<school.models.raspisanie> raspisanie { get; set; }

        public DbSet<school.models.sotrudniki> sotrudniki { get; set; }

        public DbSet<school.models.students> students { get; set; }

        public DbSet<school.models.vid> Vid { get; set; }
    }
}
