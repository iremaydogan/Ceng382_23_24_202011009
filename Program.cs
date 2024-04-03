using System;

class Program
{
    static void Main(string[] args)
    {
        ReservationHandler reservationHandler = new ReservationHandler();
        Room room1 = new Room("R001", "Conference Room", 10);

        // Rezervasyon ekleme
        Reservation reservation1 = new Reservation(DateTime.Now, DateTime.Today, "Alice", room1);
        reservationHandler.AddReservation(reservation1);

        // Rezervasyonları gösterme
        reservationHandler.DisplayWeeklySchedule();

        // Rezervasyon silme
        reservationHandler.DeleteReservation(reservation1);

        // Güncel rezervasyonları gösterme
        reservationHandler.DisplayWeeklySchedule();
    }
}