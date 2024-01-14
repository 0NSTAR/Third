using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Yandex.Cargo.Pages {
    public class RequestModel : PageModel {
        private readonly ILogger<RequestModel> _logger;

        public RequestModel(ILogger<RequestModel> logger) {
            _logger = logger;
        }

        public void OnGet() {

        }
    }

}
