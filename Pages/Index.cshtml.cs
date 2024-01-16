using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Yandex.Cargo.Models;

namespace Yandex.Cargo.Pages {
    public class IndexModel : PageModel {
        ApplicationContext context;

        public List<User> Users { get; private set; } = new();
        public List<Order> Orders { get; private set; } = new();

        public IndexModel(ApplicationContext db) {
            context = db;
        }
        public void OnGet() {
            Users = context.Users.AsNoTracking().ToList();
            Orders = context.Orders.AsNoTracking().ToList();
        }
    }
}