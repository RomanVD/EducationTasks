using Task3.PizzaMakers.interfaces;

namespace Task3.PizzaMakers.classes
{
    public class PizzaMaker : IPizzaMaker
    {
        public IPizzaRecipe GetPizzaRecipe(PizzaType type)
        {
            PizzaRecipe recipe = new PizzaRecipe(type);
            recipe.GetRecipeSteps();

            return recipe;
        }

        public IPizzaRecipe SetPizzaRecipe(PizzaType type, string[] steps, IIngredient[] ingredients)
        {
            PizzaRecipe recipe = new PizzaRecipe(type);
            recipe.SetRecipe(steps, ingredients);

            return recipe;
        }
    }
}
