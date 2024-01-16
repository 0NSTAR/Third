using Microsoft.EntityFrameworkCore;

namespace Yandex.Cargo.Models {

    public class ApplicationContext : DbContext {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbSet<User> users) {
            Users = users;
        }
        public ApplicationContext(DbSet<Order> orders) {
            Orders = orders;
        }

        public DbSet<Order> Orders { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}