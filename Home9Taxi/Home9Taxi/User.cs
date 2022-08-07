using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal class User
    {
        public User(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            PaymentMethod.Add("Cash", new Cash());
            PaymentMethod.Add("Point", new Point());
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Dictionary<string, IPaymentMethod> PaymentMethod { get; set; } = new Dictionary<string, IPaymentMethod>();

        public void ToUpCash(double money)
        {
            if (PaymentMethod.ContainsKey("Cash"))
            {
                PaymentMethod["Cash"].AddMoney(money);
            }
            else
            {
                throw new Exception("У вас нет кошелька!");
            }
        }

        public void ToUpCard(string cardName, double money)
        {
            if (PaymentMethod.ContainsKey(cardName))
            {
                PaymentMethod[cardName].AddMoney(money);
            }
            else
            {
                throw new Exception("У вас нет такой карточки!");
            }
        }

        public void AddCard(string cardName, Card card)
        {
            PaymentMethod.Add(cardName, card);
        }

        public void ShowAvailablePaymentMethods()
        {
            foreach (var paymentItem in PaymentMethod)
            {
                Console.WriteLine(paymentItem.ToString());
            }
        }

    }
}
