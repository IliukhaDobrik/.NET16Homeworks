using Newtonsoft.Json;

namespace Home13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var water = new Ingredient { Name = "Water", Price = 3.2, EnergyCost = 100, Manufacturer = "USA" };
            var milk = new Ingredient { Name = "Milk", Price = 5.1, EnergyCost = 201, Manufacturer = "Russia" };
            var tea = new Ingredient { Name = "Tea", Price = 9, EnergyCost = 157.6, Manufacturer = "Turkey" };

            var ingredients = new List<Ingredient>
            {
                water,
                milk,
                tea
            };

            var diet = new Diet
            {
                Name = "OnlyWater",
                Author = "Ilya Dobrinskiy",
                Code = "15D6A",
                Ingredients = ingredients
            };

            var serializeDiet = JsonConvert.SerializeObject(diet, Formatting.Indented);

            Console.WriteLine(serializeDiet);
        }
    }
}