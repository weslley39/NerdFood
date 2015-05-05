 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain;
using System.Configuration;
using NerdFood.Domain.Entities;
using NerdFood.Infra.Data.Interfaces;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NerdFood.Infra.Data.DbContexts
{
    public class NerdFoodContext : DbContext, IDbContext
    {
        public NerdFoodContext()
            : base("NerdFoodContext")
        {
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<NerdFoodContext>());
        }

        public IDbSet<Cliente> Cliente { get; set; }

        public IDbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }
    }

    //public class MigrationsContextFactory : IDbContextFactory<NerdFoodContext>
    //{
    //    public NerdFoodContext Create()
    //    {
    //        return new NerdFoodContext();
    //    }
    //}
}
