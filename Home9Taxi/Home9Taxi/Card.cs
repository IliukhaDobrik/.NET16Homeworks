using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Card : IPaymentMethod
    {
        public delegate void CardHandler(string message);
        public event CardHandler? Notify;

        public CardHandler? NotifyHandler { set { Notify += value; } }
        public string CardNumber { get; init; } = string.Empty;

        public double AmountOfMoney { get; private set; } = 0;

        public void AddMoney(double money)
        {
            AmountOfMoney += money;
            Notify?.Invoke($"На карту поступило {money}$");
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
                    Notify?.Invoke($"С карты списано {cost}$");
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine($"Что ты собрался покупать? На карточке не хватает денег! " +
                    $"Тебе не хватает {cost - AmountOfMoney}$");
            }
        }

        public override string ToString()
        {
            return $"Карта номер: {CardNumber}. Средств на карточке: {AmountOfMoney}$";
        }
    }
}