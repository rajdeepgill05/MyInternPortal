namespace MyInternPortal.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MyInternPortal.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyInternPortal.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyInternPortal.Models.ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!(context.Roles.Any(p => p.Name == "Admin")))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }
            if (!context.Roles.Any(p => p.Name == "Instructor"))
            {
                roleManager.Create(new IdentityRole("Instructor"));
            }
            if (!context.Roles.Any(p => p.Name == "Student"))
            {
                roleManager.Create(new IdentityRole("Student"));
            }
            if (!context.Roles.Any(p => p.Name == "Employer"))
            {
                roleManager.Create(new IdentityRole("Employer"));
            }

            ApplicationUser adminUser;

            if (!context.Users.Any(p => p.UserName == "MIPAdmin"))
            {
                adminUser = new ApplicationUser();
                adminUser.Email = "admin@internportal.com";
                adminUser.UserName = "MIPAdmin";
                userManager.Create(adminUser, "P@ssword!");
            }
            else
            {
                adminUser = context.Users.First(p => p.UserName == "MIPAdmin");
            }
            if (!userManager.IsInRole(adminUser.Id, "admin"))
            {
                userManager.AddToRole(adminUser.Id, "admin");
            }

            context.SaveChanges();
        }
    }
}
