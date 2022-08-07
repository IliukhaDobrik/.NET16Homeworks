using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Cash : IPaymentMethod
    {
        public delegate void CashHandler(string message);
        public event CashHandler? Notify;

        public double AmountOfMoney { get; private set; } = 0;

        public void AddMoney(double money)
        {
            AmountOfMoney += money;
            Notify?.Invoke($"У вас появилось {money}$");
        }

        public bool IsPaymentPossible(double cost)
        {
            if (cost > AmountOfMoney)
            {
                return false;
            }

            return true;
        }

        public void MakePayment(double cost)
        {
            try
            {
                if (IsPaymentPossible(cost))
                {
                    AmountOfMoney -= cost;
                    Notify?.Invoke($"Вы потратили {cost}$");
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine($"Что ты собрался покупать? У тебя недостаточно денег! " +
                    $"Тебе не хватает {cost - AmountOfMoney}$");
            }
        }

        public override string ToString()
        {
            return $"Налички в кошельке из крокодильей кожы: {AmountOfMoney}$";
        }
    }
}
