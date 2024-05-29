using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [BindProperty]
        public string RoomName { get; set; }
        [BindProperty]
        public DateTime? FilterStartDate { get; set; }
        [BindProperty]
        public DateTime? FilterEndDate { get; set; }
        [BindProperty]
        public int? RoomCapacity { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task OnGetAsync()
        {
            Reservations = await _context.Reservations
                .Include(r => r.Room)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var query = _context.Reservations.Include(r => r.Room).AsQueryable();

            if (!string.IsNullOrEmpty(RoomName))
            {
                query = query.Where(r => r.Room.RoomName.Contains(RoomName));
            }

            if (FilterStartDate.HasValue && FilterEndDate.HasValue)
            {
                query = query.Where(r => r.StartDate >= FilterStartDate.Value && r.EndDate <= FilterEndDate.Value);
            }

            if (RoomCapacity.HasValue)
            {
                query = query.Where(r => r.Room.Capacity >= RoomCapacity.Value);
            }

            Reservations = await query.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
                StatusMessage = "Reservation deleted successfully.";
            }
            else
            {
                StatusMessage = "Reservation not found.";
            }

            return RedirectToPage();
        }
    }
}
