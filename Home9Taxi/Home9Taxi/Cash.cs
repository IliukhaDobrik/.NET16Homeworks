using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class Cash : IPaymentMethod
    {
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
                throw new Exception("Недостаточно денежных средств в кошельке!");
            }
        }
    }
}
