namespace Task3.PizzaMakers.interfaces
{
    public interface IPizzaRecipe
    {
        string[] GetRecipeSteps();

        IIngredient[] GetIngredients();

        void SetRecipe(string[] steps, IIngredient[] ingredients);
    }
}