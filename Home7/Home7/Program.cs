namespace Home7
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            Medicine[] medicines = new Medicine[]
            {
                new Syrop("Ибуфен", 10, "Банан"),
                new Tablets("Фенкалор", 5, ConsoleColor.Green),
                new Ointment("Долгит", 15, 100)
            };

            foreach (var item in medicines)
            {
                item.Print();
                item.Instruction();

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}