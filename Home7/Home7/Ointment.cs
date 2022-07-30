namespace Home7
{
    public class Ointment : Medicine
    {
        public Ointment(string name, double cost, double mass)
            : base(name, cost)
        {
            Mass = mass;
        }
        public double Mass { get; set; } = 15;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Масса: {Mass} мг");
        }

        public override void Instruction()
        {
            Console.WriteLine("Нанести тонким слоем на кожу");
        }
    }
}
