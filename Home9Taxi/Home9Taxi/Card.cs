using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Card : IPaymentMethod
    {
        public string CardNumber { get; init; } = string.Empty;

        public double AmountOfMoney { get; private set; } = 0;

        public void AddMoney(double money)
        {
            AmountOfMoney += money;
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
            if (IsPaymentPossible(cost))
            {
                AmountOfMoney -= cost;
            }
            else
            {
                throw new Exception("Недостаточно денежных средств на карточке!");
            }
        }

        public override string ToString()
        {
            string info = string.Empty;

            info = $"Карта номер: {CardNumber}. Средств на карточке: {AmountOfMoney}$";

            return info;
        }
    }
}