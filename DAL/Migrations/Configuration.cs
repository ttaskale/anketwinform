namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.AnketContext>
    {
        public Configuration()
        {   //aþaðýdaki ayar true olursa add-migration yapmak gerekmez
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.AnketContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
