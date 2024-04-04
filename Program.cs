using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Reservation> allReservations = new List<Reservation>();
    static List<Reservation> deletedReservations = new List<Reservation>();
    static Random random = new Random();

    static void Main(string[] args)
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        string[] hours = { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" };
        PopulateReservationsWithRandomData(15, daysOfWeek, hours);
        DeleteRandomReservations(5);
        PrintReservationsTable(allReservations, "Mevcut Rezervasyonlar");
        PrintReservationsTable(deletedReservations, "Silinen Rezervasyonlar");
    }

    static void PopulateReservationsWithRandomData(int numberOfReservations, string[] days, string[] hours)
    {
        for (int i = 0; i < numberOfReservations; i++)
        {
            allReservations.Add(new Reservation
            {
                Time = DateTime.Parse(hours[random.Next(hours.Length)]),
                Date = DateTime.Now.AddDays(random.Next(days.Length)),
                ReserverName = $"Müşteri {i + 1}",
                Room = new Room { RoomId = $"R{i + 1}", RoomName = $"Oda {i + 1}", Capacity = 2 }
            });
        }
    }

    static void DeleteRandomReservations(int numberOfDeletions)
    {
        for (int i = 0; i < numberOfDeletions; i++)
        {
            int indexToDelete = random.Next(allReservations.Count);
            deletedReservations.Add(allReservations[indexToDelete]);
            allReservations.RemoveAt(indexToDelete);
        }
    }

    static void PrintReservationsTable(List<Reservation> reservations, string title)
    {
        Console.WriteLine($"\n{title}:");
        Console.WriteLine(new string('-', 60));
        Console.WriteLine("{0,-20} {1,-10} {2,-15} {3,-10}", "Zaman", "Tarih", "Rezerve Eden", "Oda Adı");
        foreach (var reservation in reservations.OrderBy(r => r.Date).ThenBy(r => r.Time))
        {
            Console.WriteLine("{0,-20} {1,-10:dd/MM/yyyy} {2,-15} {3,-10}",
                reservation.Time.ToString("HH:mm"),
                reservation.Date,
                reservation.ReserverName,
                reservation.Room.RoomName);
        }
        Console.WriteLine(new string('-', 60));
    }
}