using System;

namespace Facade
{
    class Patron
    {
        private string _name;

        public Patron(string name)
        {
            _name = name;
        }

        public string Name { get => _name; }
    }

    class FoodItem { public int DishId; }

    interface KitchenSection
    {
        FoodItem PrepDish(int dishId);
    }

    class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }
    }

    class ColdPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }

    class HotPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }

    class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }

    class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Patron patron, int coldId, int hotId, int drinkId)
        {
            Console.WriteLine($"{patron.Name} place order for cold app #{coldId}, hot entree #{hotId} adn drinks # {drinkId}.");

            var order = new Order
            {
                Appetizer = _coldPrep.PrepDish(coldId),
                Entree = _hotPrep.PrepDish(hotId),
                Drink = _bar.PrepDish(drinkId)
            };

            return order;
        }
    }
}
