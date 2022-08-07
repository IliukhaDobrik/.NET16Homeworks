using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Point : IPaymentMethod
    {
        public double AmountOfPoints { get; private set; } = 0;
        public double AmountOfMoney { get; private set; } = 0;

        public void AddPoints(double points)
        {
            AmountOfPoints += points;
            AmountOfMoney += AmountOfPoints / 3;
        }

        public void AddMoney(double money)
        {
            AmountOfMoney += money;
            AmountOfPoints += AmountOfMoney * 3;
        }

        public bool IsPaymentPossible(double points)
        {
            if (AmountOfPoints < points)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MakePayment(double points)
        {
            if (IsPaymentPossible(points))
            {
                AmountOfPoints -= points;
                AmountOfMoney -= points / 3;
            }
            else
            {
                throw new Exception("Недостаточно бонусных баллов!");
            }
        }

        public override string ToString()
        {
            string info = string.Empty;

            info = $"У вас {AmountOfPoints} бонусных баллов, это скидка на {AmountOfMoney}$";

            return info;
        }
    }
}
