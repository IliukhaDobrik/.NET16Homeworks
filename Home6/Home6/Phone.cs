namespace Home6
{
    public class Phone
    {
        private double _weight;
        private Random _chargeLevel = new Random();

        public Phone()
        {
            Weight = 0;
            Number = string.Empty;
            Model = string.Empty;
            ChargeLevel = _chargeLevel.Next(0, 100);
            Status = false;
        }

        public Phone(int weight, string number, string model)
        {
            Weight = weight;
            Number = number;
            Model = model;
            ChargeLevel = _chargeLevel.Next(0, 100);
            Status = true;
        }

        public double Weight
        {
            get { return _weight; }
            private set
            {
                if (value < 0)
                {
                    _weight = 0;
                }
                else
                {
                    _weight = value;
                }
            }
        }

        public string Number { get; set; }

        public string Model { get; private set; }

        public int ChargeLevel { get; private set; }

        public bool Status { get; private set; } //false - выключен, true - включен

        public void RecieveCall(string otherNumber)
        {
            Console.WriteLine($"Calling you {otherNumber}");
        }

        public void Call(string otherNumber)
        {
            Console.WriteLine($"You call {otherNumber}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Your phone is turned off");

            Status = false;
        }

        public void TurnOn()
        {
            Console.WriteLine("Your phone is turned on");

            Status = true;
        } 

        public void Charge()
        {
            Console.WriteLine("Wait, it's charging");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();

            ChargeLevel = 100;

            Console.WriteLine("The phone is charged");
        }
    }
}
