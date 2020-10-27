using Interfaces.Entities;
using System;
using System.Globalization;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime pickout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            CarRental car = new CarRental(pickup, pickout, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
            //Instancia um aluguel com o objeto BrazilTaxService (upcast)
            rentalService.ProcessInVoice(car);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(car.Invoice);
        }
    }
}
