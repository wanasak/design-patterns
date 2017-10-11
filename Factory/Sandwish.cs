using System.Collections.Generic;

namespace Factory
{
    abstract class Sandwish
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Sandwish()
        {
            CreateIngredients();
        }

        // FACTORY METHOD
        internal abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }
    }
    class TurkeySandwish : Sandwish
    {
        internal override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }
    class DagwoodSandwish : Sandwish
    {
        internal override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }
}
