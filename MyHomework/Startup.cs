﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MyHomework.Data;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHomework.Startup))]
namespace MyHomework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Admin role
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "dinara";
                user.Email = "dinara@gmail.com";

                string userPWD = "Password1!";

                var chkUser = UserManager.Create(user, userPWD);
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                    context.SaveChanges();

                }
            }
            if (!roleManager.RoleExists("Teacher"))
            {
                var user = new ApplicationUser();
                var role = new IdentityRole();
                role.Name = "Teacher";
                roleManager.Create(role);
                var chekUser = UserManager.Create(user);
                if (chekUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Teacher");
                    context.SaveChanges();

                }
            }

            if (!roleManager.RoleExists("Student"))
            {
                var user = new ApplicationUser();
                var role = new IdentityRole();
                role.Name = "Student";
                roleManager.Create(role);
                var chkUser = UserManager.Create(user);
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Student");
                    context.SaveChanges();

                }
            }
        }
    }
}
