using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRazorApp.Pages
{
    [Authorize]
    public class ShowReservationsModel : PageModel
    {
        private readonly Ceng382Context _context;

        public ShowReservationsModel(Ceng382Context context)
        {
            _context = context;
        }

        public List<Reservation> Reservations { get; set; }

        public async Task OnGetAsync()
        {
            Reservations = await _context.Reservations
                .Include(r => r.Room)
                .ToListAsync();
        }
    }
}