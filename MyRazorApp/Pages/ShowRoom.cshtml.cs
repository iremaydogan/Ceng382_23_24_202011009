using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [BindProperty]
        public string RoomName { get; set; }
        [BindProperty]
        public int? RoomCapacity { get; set; }

        public async Task OnGetAsync()
        {
            Rooms = await _context.Rooms.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var query = _context.Rooms.AsQueryable();

            if (!string.IsNullOrEmpty(RoomName))
            {
                query = query.Where(r => r.RoomName.Contains(RoomName));
            }

            if (RoomCapacity.HasValue)
            {
                query = query.Where(r => r.Capacity >= RoomCapacity.Value);
            }

            Rooms = await query.ToListAsync();
            return Page();
        }
    }
}
