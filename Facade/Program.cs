using System;

namespace Facade
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();

            Console.WriteLine("Hello! I'll be your server today. What is your name?");
            var name = Console.ReadLine();

            var patron = new Patron(name);

            Console.WriteLine($"Hello {patron.Name}. What appetizer would you like? (1 - 15):");
            var appId = int.Parse(Console.ReadLine());

            Console.WriteLine($"What entree would you like? (1 - 10):");
            var entreeId = int.Parse(Console.ReadLine());

            Console.WriteLine($"What drink would you like? (1 - 5):");
            var drinkId = int.Parse(Console.ReadLine());

            Console.WriteLine("I'll get that order in right away.");

            // Here where the facade simplifies
            server.PlaceOrder(patron, appId, entreeId, drinkId);
        }
    }
}
