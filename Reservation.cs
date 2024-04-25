using System;

public class Reservation
{
    public DateTime Time { get; set; }
    public DateTime Date { get; set; }
    public string ReserverName { get; set; }
    public Room Room { get; set; }
    public Reservation(DateTime time, string reserverName, Room room)
    {
        Time = time;
        Date = time; // Veya Date ve Time farklı olacaksa, uygun parametreyi ekleyin
        ReserverName = reserverName;
        Room = room;
    }

    public Reservation()
    {
    }

    // public Reservation()
    // {
    // }
}
