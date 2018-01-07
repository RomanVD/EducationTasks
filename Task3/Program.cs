using System.Collections.Generic;
using Task3.HttpManagers.classes;
using Task3.HttpManagers.interfaces;
using Task3.PizzaMakers;
using Task3.PizzaMakers.classes;
using Task3.PizzaMakers.interfaces;
using Task3.TransportStation.classes;
using Task3.TransportStation.interfaces;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaMakerProcessing();
            HttpProcessing();
        }

        static void PizzaMakerProcessing()
        {
            IPizzaMaker maker = new PizzaMaker();
            var recipe = maker.GetPizzaRecipe(PizzaType.FourChees);
            var ingredients = recipe.GetIngredients();
            var steps = recipe.GetRecipeSteps();
        }

        static void HttpProcessing()
        {
            IHttpBody body = new HttpBody("JSON", "{dfgdfgdfgfgfd;dfg;dfg;dfg}");
            IHttpHeader[] headers = {new HttpHeader("content-type", "application-json")};
            IHttpRequest request = new HttpRequest();
            request.SetRequest(body,headers);

            IHttpManager manager = new HttpManager();
            var response = manager.SendRequest(request);

        }

        static void StationProcessing()
        {
            List<IHunam> people = new List<IHunam>
            {
                new OldHuman
                {

                    Age = 123,
                    Name = "Jack"
                },
                new OldHuman
                {
                    Age = 67,
                    Name = "Ananimus"
                }
                
            };
            ITransport car = new BigCar();
            IStation station = new Station();

            station.SetPeople(car,people);
            station.GetPople(car);

        }
    }
}
