using System;
using System.Globalization;
using Exec05Interface.Entities;

namespace Exec05Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MMdyyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MMdyyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental cr = new CarRental(start, finish, new Vehicle(model));
        }
    }
}
