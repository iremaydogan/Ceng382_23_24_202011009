using System.Collections.Generic;

public class ReservationHandler
{
    private List<Reservation> reservations = new List<Reservation>();

    public object Reservations { get; internal set; }

    public void AddReservation(Reservation reservation)
    {
        reservations.Add(reservation);
    }

    public void DisplayWeeklySchedule()
    {
        foreach (var reservation in reservations)
        {
            Console.WriteLine($"Reservation for {reservation.Room.RoomName} on {reservation.Date} at {reservation.Time}, reserved by {reservation.ReserverName}");
        }
    }

    internal Reservation FindReservationById(string? reservationId)
    {
        throw new NotImplementedException();
    }
    public bool DeleteReservation(string reserverName, DateTime date, DateTime time)
    {
        var reservationToDelete = reservations.FirstOrDefault(r =>
            r.ReserverName.Equals(reserverName, StringComparison.OrdinalIgnoreCase) &&
            r.Date.Date == date.Date &&
            r.Time.TimeOfDay == time.TimeOfDay);

        if (reservationToDelete != null)
        {
            reservations.Remove(reservationToDelete);
            return true;
        }

        return false;
    }

}
