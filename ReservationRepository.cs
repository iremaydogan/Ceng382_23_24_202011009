using System.Collections.Generic;
using System.Text.Json;
using System.IO;

public class ReservationRepository : IReservationRepository
{
    private const string FilePath = "ReservationData.json";
    private List<Reservation> _reservations;

    public ReservationRepository()
    {
        // Dosyadan mevcut rezervasyonları yükle
        _reservations = LoadReservationsFromFile();
    }

    public void AddReservation(Reservation reservation)
    {
        _reservations.Add(reservation);
        SaveReservationsToFile();
    }

    public void DeleteReservation(Reservation reservation)
    {
        _reservations.Remove(reservation);
        SaveReservationsToFile();
    }

    public List<Reservation> GetAllReservations()
    {
        return _reservations;
    }

    private List<Reservation> LoadReservationsFromFile()
    {
        if (!File.Exists(FilePath))
        {
            return new List<Reservation>();
        }

        string json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<Reservation>>(json) ?? new List<Reservation>();
    }

    private void SaveReservationsToFile()
    {
        string json = JsonSerializer.Serialize(_reservations, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }
}
