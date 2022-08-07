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
        public string CarColor { get; set; } = string.Empty;
        public string Model { get; init; } = string.Empty;
      
        public double GetPriceOfRide()
        {
            return 7;
        }

        public void MakeRide(in User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                $"{CarColor} машине, модели {Model}");
            
        }
    }
}
