namespace Home7
{
    public class Syrop : Medicine
    {
        public Syrop(string name, double cost, string taste) 
            : base(name, cost)
        {
            Taste = taste;
        }
        public string Taste { get; set; } = string.Empty;
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сироп со вкусом {Taste}");
        }

        public override void Instruction()
        {
            Console.WriteLine("Налить 10 мл и выпить натощак");
        }
    }
}
