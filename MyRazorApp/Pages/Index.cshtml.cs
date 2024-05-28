using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace MyRazorApp.Pages
{
    [Authorize(Policy = "RequireLoggedIn")]
    public class IndexModel : PageModel
    {
        public string UserName { get; private set; }

        public void OnGet()
        {
            UserName = User.Identity?.Name ?? "Guest";
        }
    }
}