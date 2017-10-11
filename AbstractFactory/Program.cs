using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;

            ReceipeFactory factory;

            switch (input)
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;
                case 'C':
                    factory = new ChildReceipeFactory();
                    break;
                default:
                    throw new NotImplementedException();
            }

            var sandwish = factory.CreateSandwish();
            var dessert = factory.CreateDessert();

            Console.WriteLine($"\nSandwish: {sandwish.GetType().Name}");
            Console.WriteLine($"Dessert: {dessert.GetType().Name}");
        }
    }
}
