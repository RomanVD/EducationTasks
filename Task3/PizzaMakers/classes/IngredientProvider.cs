using Task3.PizzaMakers.classes.ingredients;
using Task3.PizzaMakers.interfaces;

namespace Task3.PizzaMakers.classes
{
    public class IngredientProvider: IIngredientProvider
    { 
        public IIngredient[] GetIngredients(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.FourChees:
                    return new IIngredient[]{new Chees()};
                case PizzaType.Karbonara:
                    return new IIngredient[] { new Chees(), new Ingredient()};
                case PizzaType.Peperony:
                    return new IIngredient[] { new Ingredient() };
                default: return null;
            }
        }        
    }
}
