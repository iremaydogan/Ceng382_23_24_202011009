using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Data;
using MyRazorApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyRazorApp.Pages
{
    [Authorize]
    public class ShowRoomModel : PageModel
    {
        private readonly Ceng382Context _context;

        public ShowRoomModel(Ceng382Context context)
        {
            _context = context;
        }

        public List<Room> Rooms { get; set; }

        public void OnGet()
        {
            Rooms = _context.Rooms.ToList();
        }
    }
}
