using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal interface IPaymentMethod
    {
        bool IsPaymentPossible(double money);
        void MakePayment(double money);
        void AddMoney(double money);
    }
}
