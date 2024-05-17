using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Data;
using MyRazorApp.Models;

namespace MyApp.Namespace
{
    public class CreateRoomModel : PageModel
    {
        [BindProperty]
        public Room? rooms { get; set; } = default!;
        public Ceng382Context NewRoom = new();



        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || rooms == null)
            {
                return Page();
            }
            NewRoom.Add(rooms);
            NewRoom.SaveChanges();
            return RedirectToAction("Get");
        }
    }
}
