public class ReservationService : IReservationService
{
    private readonly IReservationRepository _reservationRepository;
    private readonly ILogger _logger;

    public ReservationService(IReservationRepository reservationRepository, ILogger logger)
    {
        _reservationRepository = reservationRepository ?? throw new ArgumentNullException(nameof(reservationRepository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void AddReservation(Reservation reservation)
    {
        _reservationRepository.AddReservation(reservation);
        _logger.Log($"Reservation added: {reservation}");
        // Diğer işlemler...
    }

    public void DeleteReservation(Reservation reservation)
    {
        _reservationRepository.DeleteReservation(reservation);
        _logger.Log($"Reservation deleted: {reservation}");
        // Diğer işlemler...
    }

    public void DeleteReservation()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Reservation> GetAllReservations()
    {
        return _reservationRepository.GetAllReservations();
    }

    // Diğer IReservationService metodlarının uygulamaları...
}
