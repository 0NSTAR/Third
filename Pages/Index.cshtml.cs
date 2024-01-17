using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Yandex.Cargo.Models;

namespace Yandex.Cargo.Pages {
    public class IndexModel : PageModel {
        readonly ApplicationContext context;
        public List<Order> Orders { get; private set; } = new();

        public IndexModel(ApplicationContext db) {
            context = db;
        }
        public void OnGet() {
            Orders = context.Orders.AsNoTracking().ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id) {
            var order = await context.Orders.FindAsync(id);

            if (order != null) {
                context.Orders.Remove(order);
                await context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}