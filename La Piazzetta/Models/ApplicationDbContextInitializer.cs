using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace La_Piazzetta.Models
{
    public class ApplicationDbContextInitializer
    {
        private RoleStore<IdentityRole> roleStore;
        private RoleManager<IdentityRole> roleManager;

        private UserStore<ApplicationUser> userStore;
        private UserManager<ApplicationUser> userManager;

        public ApplicationDbContextInitializer(ApplicationDbContext context)
        {
            if (context.Users.Any() || context.Roles.Any())
            {
                return;
            }

            roleStore = new RoleStore<IdentityRole>(context);
            roleManager = new RoleManager<IdentityRole>(roleStore);

            userStore = new UserStore<ApplicationUser>(context);
            userManager = new UserManager<ApplicationUser>(userStore);

            SeedRoles();
            SeedUsers();

            context.SaveChanges();
        }

        private void SeedUsers()
        {
            var adminUser = new ApplicationUser
            {
                UserName = "admin@pizzetta.com",
                Email = "admin@pizzetta.com",
            };
            var managerUser = new ApplicationUser
            {
                UserName = "manager@pizzetta.com",
                Email = "manager@pizzetta.com",
            };
            var employeeUser = new ApplicationUser
            {
                UserName = "employee@pizzetta.com",
                Email = "employee@pizzetta.com",
            };
            var customerUser = new ApplicationUser
            {
                UserName = "customer@pizzetta.com",
                Email = "customer@pizzetta.com",
            };

            userManager.Create(adminUser, "Admin1!");
            userManager.AddToRole(adminUser.Id, "Admin");

            userManager.Create(managerUser, "Manager1!");
            userManager.AddToRole(managerUser.Id, "Manager");

            userManager.Create(employeeUser, "Employee1!");
            userManager.AddToRole(employeeUser.Id, "Employee");

            userManager.Create(customerUser, "Customer1!");
            userManager.AddToRole(customerUser.Id, "Customer");
        }

        private void SeedRoles()
        {
            var adminRole = new IdentityRole("Admin");
            var managerRole = new IdentityRole("Manager");
            var employeeRole = new IdentityRole("Employee");
            var customerRole = new IdentityRole("Customer");

            roleManager.Create(adminRole);
            roleManager.Create(managerRole);
            roleManager.Create(employeeRole);
            roleManager.Create(customerRole);
        }
    }
}