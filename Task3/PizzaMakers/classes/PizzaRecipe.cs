using Task3.PizzaMakers.interfaces;

namespace Task3.PizzaMakers.classes
{
    public class PizzaRecipe : IPizzaRecipe
    {
        private readonly PizzaType _type;
        private string[] _steps;
        private IIngredient[] _ingredients;

        public PizzaRecipe(PizzaType type)
        {
            _type = type;
        }

        public string[] GetRecipeSteps()
        {
            switch (_type)
            {
                case PizzaType.FourChees:
                    return new string[1];
                case PizzaType.Karbonara:
                    return new string[2];
                case PizzaType.Peperony:
                    return new string[4];
                default: return null;
            }
        }

        public IIngredient[] GetIngredients()
        {
            IngredientProvider provider = new IngredientProvider();

            return provider.GetIngredients(_type);
        }

        public void SetRecipe(string[] steps, IIngredient[] ingredients)
        {
            _steps = steps;
            _ingredients = ingredients;
        }
    }
}
