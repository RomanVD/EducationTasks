using Task3.PizzaMakers.interfaces;

namespace Task3.PizzaMakers.classes.ingredients
{
    class Chees : IIngredient
    {
        public int Weight => 15;
        public string Name => "Chees";
        public string Color => "Green";
    }
}
