using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Car : Vehicle, ITaxi
    {
        public static int MaxSpeed = 120;

        public Car() : base() { }

        public Car(string govermentNumber, double fuelConsumption, string carColor, string company)
            : base(govermentNumber, fuelConsumption)
        {
            CarColor = carColor;
            Company = company;
        }

        public string CarColor { get; set; } = string.Empty;
        public string Company { get; init; } = string.Empty;
      
        public double GetPriceOfRide()
        {
            return 7;
        }

        public void MakeRide(in User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                $"{CarColor} машине, изготовитель {Company}");
        }
    }
}
