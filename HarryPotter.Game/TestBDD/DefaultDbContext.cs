using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBDD.Models;

namespace TestBDD
{
    /// <summary>
    ///  C'est mon ORM /D
    /// </summary>
    internal class DefaultDbContext : DbContext
    {
        #region Constructors
        public DefaultDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected DefaultDbContext()
        {
        }
        #endregion

        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Sert ici uniquement pour la création de la requete SQL
            modelBuilder.Entity<Ennemi>().ToTable("Ennemi");
            modelBuilder.Entity<Ennemi>().Property(item => item.PointsDeVie).HasColumnName("PointsVie");

            
            // Sert pour la vérification avant ajout dans le DbSet
            modelBuilder.Entity<Ennemi>().HasKey(item => item.Id);
            modelBuilder.Entity<Ennemi>().Property(item => item.Id).ValueGeneratedOnAdd();

        }
        #endregion

        #region Properties
        public DbSet<Ennemi> Enemies { get; set; }
        #endregion
    }
}
