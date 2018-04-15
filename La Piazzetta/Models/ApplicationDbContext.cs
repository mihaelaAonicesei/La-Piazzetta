using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace La_Piazzetta.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.CreateIfNotExists();
        }

        public ApplicationDbContext(string connString)
            : base(connString, throwIfV1Schema: false)
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favourites> Favourites { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<Vote> Vote { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}