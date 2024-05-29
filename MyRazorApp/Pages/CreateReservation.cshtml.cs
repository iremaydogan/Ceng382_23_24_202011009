using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyRazorApp.Pages
{
    [Authorize]
    public class CreateReservationModel : PageModel
    {
        private readonly Ceng382Context _context;

        public CreateReservationModel(Ceng382Context context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public SelectList RoomList { get; set; }

        public class InputModel
        {
            public int RoomId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }

        public async Task OnGetAsync()
        {
            var rooms = await _context.Rooms.ToListAsync();
            RoomList = new SelectList(rooms, "Id", "RoomName");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var reservation = new Reservation
            {
                RoomId = Input.RoomId,
                StartDate = Input.StartDate,
                EndDate = Input.EndDate,
                UserId = userIdClaim // Kullanıcı kimliğini buradan alıyoruz
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            return RedirectToPage("/ShowReservation");
        }
    }
}
