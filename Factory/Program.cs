using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkeySanwish = new TurkeySandwish();
            var dagwoodSandwish = new DagwoodSandwish();

            Console.WriteLine($"Number of Turkey's ingredients is {turkeySanwish.Ingredients.Count}");
            Console.WriteLine($"Number of Dagwood's ingredients is {dagwoodSandwish.Ingredients.Count}");
        }
    }
}
