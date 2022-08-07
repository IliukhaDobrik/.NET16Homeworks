using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Card : IPaymentMethod
    {
        public Card(string cardNumber, double amountOfMoney)
        {
            CardNumber = cardNumber;
            AmountOfMoney = amountOfMoney;
        }

        public string CardNumber { get; }

        public double AmountOfMoney { get; private set; }

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
                throw new Exception("Недостаточно денег");
            }
        }
    }
}
