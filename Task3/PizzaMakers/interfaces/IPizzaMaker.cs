namespace Task3.PizzaMakers.interfaces
{
    public interface IPizzaMaker
    {
        IPizzaRecipe GetPizzaRecipe(PizzaType type);

        IPizzaRecipe SetPizzaRecipe(PizzaType type, string[] steps, IIngredient[] ingredients);
    }
}