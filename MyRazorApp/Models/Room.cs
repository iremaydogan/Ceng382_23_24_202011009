

namespace MyRazorApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string? RoomName { get; set; }
        public int? Capacity { get; set; }
        public List<Reservation> Reservations { get; set; }

    }
}

