using Microsoft.AspNetCore.Identity;
using MyRazorApp.Models;
namespace MyRazorApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime ReservationDate { get; set; }
        public string UserId { get; set; } // Kullanıcı kimliğini saklayacak alan
    }
}

