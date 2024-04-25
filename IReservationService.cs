public interface IReservationService
{
    void AddReservation(Reservation reservation);
    void DeleteReservation(Reservation reservation);
    void DeleteReservation();
    IEnumerable<Reservation> GetAllReservations();
    // İhtiyacınıza göre diğer metodlar eklenebilir, örneğin:
    // Reservation GetReservationById(string id);
    // void UpdateReservation(Reservation reservation);
}
