namespace Home7
{
    internal class Tablets : Medicine
    {
        public Tablets(string name, double cost, ConsoleColor color)
            : base(name, cost)
        {
            Color = color;
        }
        public ConsoleColor Color { get; set; } = ConsoleColor.White;
        public override void Print()
        {
            base.Print();

            Console.ForegroundColor = Color;
            Console.WriteLine($"Цвет таблеток {Color}");
            Console.ResetColor();
        }

        public override void Instruction()
        {
            Console.WriteLine("Принимать три раза в день после еды");
        }
    }
}
