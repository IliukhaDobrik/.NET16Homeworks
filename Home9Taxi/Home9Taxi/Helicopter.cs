using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Helicopter : Vehicle, ITaxi
    {
        private double _mass = 300;

        public bool IsCargo { get; set; } = false; //является ли грузовым
        public double Mass 
        { 
            get => _mass; 
            private set 
            {
                if (value < 300)
                {
                    _mass = 300;
                }
                else
                {
                    _mass = value;
                }
            } 
        }
        public double GetPriceOfRide()
        {
            return 50;
        }

        public void MakeRide(in User user)
        {
            if (IsCargo)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                    $"грузовом вертолёте, массой {Mass}");
            }
            else
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                    $"пассажирском вертолёте, массой {Mass}");
            }
        }
    }
}
