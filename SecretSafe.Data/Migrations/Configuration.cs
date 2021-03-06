namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.SecretSafeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
           
        }

        protected override void Seed(Data.SecretSafeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.SecurityLevels.AddOrUpdate(
                s => s.SecurityLevelId, 
                new SecretSafe.Models.SecurityLevel()
                {
                    SecurityLevelId = 1,
                    Name = "Normal Security",
                    CreatedOn = DateTime.Now
                },
                 new SecretSafe.Models.SecurityLevel()
                 {
                     SecurityLevelId = 2,
                     Name = "Medium Security",
                     CreatedOn = DateTime.Now
                 },
                  new SecretSafe.Models.SecurityLevel()
                  {
                      SecurityLevelId = 3,
                      Name = "Pro Security",
                      CreatedOn = DateTime.Now
                  },
                   new SecretSafe.Models.SecurityLevel()
                   {
                       SecurityLevelId = 4,
                       Name = "Maximum Security",
                       CreatedOn = DateTime.Now
                   }
            );
        }
    }
}
