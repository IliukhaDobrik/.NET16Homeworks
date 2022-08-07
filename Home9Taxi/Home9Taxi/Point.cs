using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Point : IPaymentMethod
    {
        public delegate void PointHandler(string message);
        public event PointHandler? Notify;

        public double AmountOfPoints { get; private set; } = 0;
        public double AmountOfMoney { get; private set; } = 0;

        public void AddPoints(double points)
        {
            AmountOfPoints += points;
            AmountOfMoney += points / 3;
            Notify?.Invoke($"Вы заработали {points} баллов");
        }

        public void AddMoney(double money)
        {
            AmountOfMoney += money;
            AmountOfPoints += money * 3;
            Notify?.Invoke($"Вы заработали {money * 3} баллов");
        }

        public bool IsPaymentPossible(double money)
        {
            if (AmountOfPoints < money * 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MakePayment(double money)
        {
            try
            {
                if (IsPaymentPossible(money))
                {
                    AmountOfPoints -= money * 3;
                    AmountOfMoney -= money;
                    Notify?.Invoke($"Вы потратили {money * 3} балла");
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine($"Недостаточно бонусных баллов! Тебе не хватает {money*3 - AmountOfMoney}");
            }
        }

        public override string ToString()
        {
            return $"У вас {AmountOfPoints} бонусных баллов, это скидка на {AmountOfMoney}$";
        }
    }
}
