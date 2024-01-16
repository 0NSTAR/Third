using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yandex.Cargo.Models;

namespace Yandex.Cargo.Pages {
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel {
        ApplicationContext context;

        [BindProperty]
        public Order Order { get; set; } = new();
        public CreateModel(ApplicationContext db) {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync() {
            try {
                context.Orders.Add(Order);
                await context.SaveChangesAsync();
                return RedirectToPage("Index");
            } catch(Exception) {
                ModelState.AddModelError("", "An error occurred while processing your request.");
                return Page();
            }
        }
    }
}
