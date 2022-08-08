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

        public Car(string govermentNumber, double fuelConsumption)
            : base(govermentNumber, fuelConsumption) { }

        public Car(string govermentNumber, double fuelConsumption, string carColor, string company)
            : base(govermentNumber, fuelConsumption)
        {
            CarColor = carColor;
            Company = company;
        }

        public string CarColor { get; set; } = "Белая";
        public string Company { get; init; } = "Fiat";


        public double GetPriceOfRide()
        {
            return 7;
        }

        public void MakeRide(in User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} совершил(ла) поездку на " +
                $"{CarColor} машине, изготовитель {Company}");
        }

        public override int GetCountOfSeats()
        {
            try
            {
                if (Company is "Fiat")
                    return 5;
                if (Company is "BMW")
                    return 4;
                if (Company is "Mercedes")
                    return 5;
                if (Company is "Ferrari")
                    return 2;
                throw new Exception();

                //switch (Company)
                //{
                //    case "Fiat":
                //        return 5;
                //    case "BMW":
                //        return 4;
                //    case "Mercedes":
                //        return 5;
                //    case "Ferrari":
                //        return 2;
                //    default:
                //        throw new Exception();
                //}
            }
            catch (Exception)
            {
                Console.WriteLine("Мы не знаем сколько мест в вашей машине");
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Машина {CarColor} цвета, гос. номер: {GovermentNumber}, " +
                $"изготовитель {Company}, потребление топлива: {FuelConsumption}. Цена поездки: {GetPriceOfRide()}$";
        }
    }
}
