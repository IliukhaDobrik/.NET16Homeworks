using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Motorbike : Vehicle, ITaxi
    {
        public static int MaxSpeed = 200;
        private int _power = 50;

        public Motorbike() : base() { }

        public Motorbike(string govermentNumber, double fuelConsumption, bool isWithSidecar, int power)
            : base(govermentNumber, fuelConsumption)
        {
            IsWithSidecar = isWithSidecar;
            Power = power;
        }

        public bool IsWithSidecar { get; set; } = false; //с коляской ли мотоцикл
        public int Power 
        { 
            get => _power; 
            private set
            {
                if (value < 50)
                {
                    _power = 50;
                }
                else
                {
                    _power = value;
                }
            } 
        } 

        public double GetPriceOfRide()
        {
            return 10;
        }

        public void MakeRide(in User user)
        {
            if (IsWithSidecar)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                    $"мотоцикле, мощность {Power}, с коляской");
            }
            else
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                    $"мотоцикле, мощность {Power}, без коляски");
            }
        }
    }
}
