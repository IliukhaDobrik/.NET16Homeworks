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

        public Helicopter() : base() { }

        public Helicopter(string govermentNumber, double fuelConsumption)
            : base(govermentNumber, fuelConsumption) { }

        public Helicopter(string govermentNumber, double fuelConsumption, bool isCargo, double mass)
            : base(govermentNumber, fuelConsumption)
        {
            IsCargo = isCargo;
            Mass = mass;
        }
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

        public override int GetCountOfSeats()
        {
            if (IsCargo)
            {
                return 10;
            }

            return 3;
        }

        public override string ToString()
        {
            if (IsCargo)
            {
                return $"Грузовой вертолёт, гос. номер: {GovermentNumber}, " +
                    $"массой {Mass}, потребление топлива: {FuelConsumption}";
            }
            else
            {
                return $"Пассажирский вертолёт, гос. номер: {GovermentNumber}, " +
                    $"массой {Mass}, потребление топлива: {FuelConsumption}. Цена поездки: {GetPriceOfRide()}$";
            }
        }
    }
}
