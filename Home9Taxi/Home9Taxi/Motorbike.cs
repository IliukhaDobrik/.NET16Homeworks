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
        public bool IsWithSidecar { get; set; }//с коляской ли мотоцикл
        public int Power { get; init; } = 0;

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
