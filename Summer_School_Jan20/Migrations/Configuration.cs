namespace Summer_School_Jan20.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Summer_School_Jan20.Models.DatabaseForSummerApp>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Summer_School_Jan20.Models.DatabaseForSummerApp";
        }

        protected override void Seed(Summer_School_Jan20.Models.DatabaseForSummerApp context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }


    }
}
