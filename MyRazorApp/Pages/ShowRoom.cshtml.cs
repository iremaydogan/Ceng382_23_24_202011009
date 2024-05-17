using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Data;
using MyRazorApp.Models;

namespace MyApp.Namespace
{
    public class ShowRoomModel : PageModel
    {
        public Ceng382Context rooms = new();
        public List<Room> Rooms { get; set; } = default!;
        public void OnGet()
        {
            // LINQ query to retrieve items where IsDeleted is false
            Rooms = (from item in rooms.Room
                         //   where item.IsDeleted == false
                     select item).ToList();
        }
    }
}
