namespace Task3.PizzaMakers.interfaces
{
    public interface IIngredientProvider
    {
        IIngredient[] GetIngredients(PizzaType type);
    }
}