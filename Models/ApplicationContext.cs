using Microsoft.EntityFrameworkCore;

namespace Yandex.Cargo.Models {

    public class ApplicationContext : DbContext {
        public ApplicationContext() { }

        public DbSet<Order> Orders { get; set; } = null!;

        public ApplicationContext(DbSet<Order> orders) {
            Orders = orders;
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}