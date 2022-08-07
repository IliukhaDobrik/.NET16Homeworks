using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal abstract class Vehicle
    {
        private double _fuelConsumption = 0;
        private int _countOfSeats = 0;

        public Vehicle() { }

        public Vehicle(string govermentNumber, double fuelConsumption)
        {
            GovermentNumber = govermentNumber;
            FuelConsumption = fuelConsumption;
        }

        public int CountOfSeats 
        { 
            get => _countOfSeats;
            private set
            {
                if (value < 0)
                {
                    _countOfSeats = 0;
                }
                else
                {
                    _countOfSeats = value;
                }
            }
        }

        public string GovermentNumber { get; init; } = string.Empty;
        public double FuelConsumption
        {
            get => _fuelConsumption;
            private set
            {
                if (value < 0)
                {
                    _fuelConsumption = 0;
                }
                else
                {
                    _fuelConsumption = value;
                }
            }
        }

        public abstract int GetCountOfSeats();
    }
}
