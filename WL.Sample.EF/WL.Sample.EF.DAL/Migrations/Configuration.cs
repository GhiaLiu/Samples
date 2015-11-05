namespace WL.Sample.EF.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WL.Sample.EF.DAL.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WL.Sample.EF.DAL.MyDbContext context)
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
            context.SysEmployees.Add(new SysEmployee()
            {
                SysEmployeeId = 104001,
                Name = "JB.Lin",
                IsEnabled = true
            });

            context.SysRoles.Add(new SysRole()
            {
                Name = "開發一課",
                Description = "開發一課",
                IsEnabled = true
            });

            context.SysFunctions.Add(new SysFunction()
            {
                Name = "HR-Overtime Report",
                IsEnabled = true
            });
            context.SysFunctions.Add(new SysFunction()
            {
                Name = "TMS-Driver List",
                IsEnabled = true
            });

            context.SaveChanges();

        }
    }
}
