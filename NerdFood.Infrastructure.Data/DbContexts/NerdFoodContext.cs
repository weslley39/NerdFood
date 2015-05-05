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
 using NerdFood.Infrastructure.Data.Config;

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
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(x => x.Name == x.ReflectedType.Name + "Id")
                .Configure(x => x.IsKey());

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());

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
