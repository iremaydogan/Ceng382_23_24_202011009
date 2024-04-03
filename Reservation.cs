public class Reservation
{
    public DateTime Time { get; set; }
    public DateTime Date { get; set; }
    public string ReserverName { get; set; }
    public Room Room { get; set; }

    public Reservation(DateTime time, DateTime date, string reserverName, Room room)
    {
        Time = time;
        Date = date;
        ReserverName = reserverName;
        Room = room;
    }
}
