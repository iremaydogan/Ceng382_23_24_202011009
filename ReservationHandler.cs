using System.Collections.Generic;

public class ReservationHandler
{
    private List<Reservation> reservations = new List<Reservation>();

    public void AddReservation(Reservation reservation)
    {
        reservations.Add(reservation);
    }

    public void DeleteReservation(Reservation reservation)
    {
        reservations.Remove(reservation);
    }

    public void DisplayWeeklySchedule()
    {
        // Haftalık programı gösterecek kodlar buraya yazılacak.
        // Örnek olarak şu an sadece rezervasyonları listeliyoruz.
        foreach (var reservation in reservations)
        {
            Console.WriteLine($"Room: {reservation.Room.RoomName}, Time: {reservation.Time}, Date: {reservation.Date}, Reserved by: {reservation.ReserverName}");
        }
    }
}
