using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Data;
using MyRazorApp.Models;
using static Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal.ExternalLoginModel;

namespace MyRazorApp.Pages
{
    [Authorize]
    public class CreateRoomModel : PageModel
    {
        private readonly Ceng382Context _context;

        public CreateRoomModel(Ceng382Context context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var room = new Room
            {
                RoomName = Input.RoomName,
                Capacity = Input.Capacity,
            };
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return RedirectToPage("/ShowRoom");
        }
        public class InputModel
        {
            public string RoomName { get; set; }
            public int Capacity { get; set; }
        }
    }
}
