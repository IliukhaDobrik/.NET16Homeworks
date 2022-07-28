namespace Home6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone(500, "+375298732839", "Honor");

            Console.WriteLine($"My number is {myPhone.Number}");
            Console.WriteLine($"Weight of my phone is {myPhone.Weight}");
            Console.WriteLine($"Model of my phone is {myPhone.Model}" + Environment.NewLine);

            myPhone.RecieveCall("+375295560894" + Environment.NewLine);

            Console.WriteLine($"Charge level: {myPhone.ChargeLevel}%" + Environment.NewLine);

            if (myPhone.ChargeLevel <= 5)
            {
                Console.WriteLine("Low garge level");
                myPhone.TurnOff();
            }

            if (myPhone.ChargeLevel <= 20 && myPhone.ChargeLevel > 5)
            {
                myPhone.Charge();
            }

            Console.ReadKey();
        }
    }
}