namespace NerdFood.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationIdentity : DbMigrationsConfiguration<NerdFood.Infra.Data.DbContexts.IdentityContext>
    {
        public ConfigurationIdentity()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NerdFood.Infra.Data.DbContexts.IdentityContext context)
        {
            //  This method will be called after migrating to the latest version.
        }
    }
}

