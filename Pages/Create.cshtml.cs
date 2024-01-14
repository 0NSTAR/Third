using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Yandex.Cargo.Pages {
    public class CreateModel : PageModel {
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(ILogger<CreateModel> logger) {
            _logger = logger;
        }

        public void OnGet() {

        }
    }
}
