using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class KookboekContext : DbContext
    {
        public KookboekContext() : base("KookboekDb")
        {
            Database.SetInitializer(new KookboekInitializer());
            Database.Initialize(false);
        }

        public DbSet<Recept> Recepten { get; set; }
        public DbSet<Ingrediënt> Ingrediënten { get; set; }
        public DbSet<Bereiding> Bereidingen { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngrediëntEenheid>()
                .HasRequired(i => i.Recept)
                .WithMany(r => r.Ingrediënten)
                .HasForeignKey(i => i.ReceptID);
            modelBuilder.Entity<IngrediëntEenheid>()
                .HasRequired(i => i.Ingrediënt)
                .WithMany(i => i.Usages)
                .HasForeignKey(i => i.IngredientID);

            modelBuilder.Entity<Tag>()
                .HasMany(t => t.Recepten)
                .WithMany(r => r.Tags);

            //modelBuilder.Entity<Archief>()
            //.HasMany(a => a.Films)
            //.WithMany(f => f.Archieven);
            //modelBuilder.Entity<Archief>()
            //   .HasMany(a => a.Afleveringen)
            //   .WithMany(s => s.Archieven);

            base.OnModelCreating(modelBuilder);
        }
    }
}
