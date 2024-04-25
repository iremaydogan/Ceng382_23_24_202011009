// using Microsoft.Extensions.DependencyInjection;
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // DI container'ı yapılandır
//         var serviceProvider = new ServiceCollection()
//             .AddSingleton<ILogger, FileLogger>()
//             .AddSingleton<IReservationRepository, ReservationRepository>()
//             .AddTransient<IReservationService, ReservationService>()
//             .BuildServiceProvider();

//         // DI kullanarak servisleri al
//         var reservationService = serviceProvider.GetService<IReservationService>();

//         // Uygulama akışını başlat
//         var reservation = new Reservation(DateTime.Now, "John Doe", new Room("1", "Conference Room", 10));
//         reservationService.AddReservation(reservation);

//         // Diğer işlemler...
//     }
// }
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IReservationRepository, ReservationRepository>()
            .AddSingleton<ILogger, FileLogger>()
            .AddTransient<IReservationService, ReservationService>()
            .BuildServiceProvider();

        var reservationService = serviceProvider.GetService<IReservationService>();

        while (true)
        {
            Console.WriteLine("1. Rezervasyon Ekle");
            Console.WriteLine("2. Rezervasyon Sil");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddReservation(reservationService);
                    break;
                case "2":
                    DeleteReservation(reservationService);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }

    static void AddReservation(IReservationService reservationService)
    {
        // Kullanıcıdan rezervasyon verileri al
        // Örneğin: 
        Console.Write("Oda ID: ");
        var roomId = Console.ReadLine();
        Console.Write("Rezervasyon Yapanın Adı: ");
        var name = Console.ReadLine();
        // ...

        // Rezervasyon oluştur ve servise ekle
        var reservation = new Reservation(/* parametreler */);
        reservationService.AddReservation(reservation);
    }

    static void DeleteReservation(IReservationService reservationService)
    {
        // Kullanıcıdan silinecek rezervasyon ID'si al
        Console.Write("Silinecek rezervasyon ID: ");
        var reservationId = Console.ReadLine();

        // Rezervasyonu servis üzerinden sil
        reservationService.DeleteReservation(/* parametreler */);
    }
}
