namespace Home9Taxi
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            var taxis = new List<ITaxi>
            {
                new Car("1111", 7.6, "Серая", "Fiat"),
                new Motorbike("2222", 3.2, false, 600),
                new Helicopter("3333", 16.7, false, 1200)
            };

            Console.ReadKey();
        }
    }
}