namespace Home7
{
    public abstract class Medicine
    {
        private double _cost = 0;

        public Medicine(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; } = string.Empty;
        public double Cost
        {
            get 
            { 
                return _cost; 
            }
            set 
            { 
                if(value < 0)
                {
                    _cost = 0;
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Это лекарство назывыается {Name}, его стоимость: {Cost}$");
        }

        public abstract void Instruction();
    }
}
