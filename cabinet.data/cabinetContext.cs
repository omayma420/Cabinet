using cabinet.domain.entites;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace cabinet.data
{
    public partial class cabinetContext : DbContext
    {
        public cabinetContext()
            : base("name=cabinetContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<specialite> specialites { get; set; }
        public DbSet<medecin> medecines { get; set; }

        public DbSet<patient> patients { get; set; }

        public DbSet<rendezvous> rendezvouss { get; set; }
        public DbSet<dossier> dossier { get; set; }
    }
}
