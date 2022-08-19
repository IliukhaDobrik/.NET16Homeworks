namespace Home11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            microwave.WarmUpCompleted += WarmUpCompletedHandler;

            microwave.WarmUp("Драники");
            microwave.WarmUp("Шавуха");
        }

        static void WarmUpCompletedHandler(string nameOfDish)
        {
            Console.WriteLine($"Ваша еда готова: {nameOfDish}");
        }
    }
}