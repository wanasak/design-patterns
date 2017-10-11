namespace AbstractFactory
{
    abstract class Sandwish { }
    abstract class Dessert { }

    // ABSTRACT FACTORY
    abstract class ReceipeFactory
    {
        public abstract Sandwish CreateSandwish();
        public abstract Dessert CreateDessert();
    }

    class BLT : Sandwish { }
    class CremeBrulee : Dessert { }

    class AdultCuisineFactory : ReceipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwish CreateSandwish()
        {
            return new BLT();
        }
    }

    class PBandJ : Sandwish { }
    class IceCreamSundae : Dessert { }

    class ChildReceipeFactory : ReceipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }

        public override Sandwish CreateSandwish()
        {
            return new PBandJ();
        }
    }
}
