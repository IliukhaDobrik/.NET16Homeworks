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
            try
            {
                PaymentMethod["Cash"].AddMoney(money);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("У вас нет кошелька! Ваши средства оплаты: ".ToUpper());
                ShowAvailablePaymentMethods();
            }
        }

        public void ToUpCard(string cardName, double money)
        {
            try
            {
                PaymentMethod[cardName].AddMoney(money);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("У вас нет такой карты! Ваши средства оплаты: ".ToUpper());
                ShowAvailablePaymentMethods();
            }
        }

        public void AddCard(string cardName, Card card)
        {
            PaymentMethod.Add(cardName, card);
        }

        public void ShowAvailablePaymentMethods()
        {
            Console.WriteLine("==================================");
            foreach (var paymentItem in PaymentMethod)
            {
                if (paymentItem.Value is Card)
                {
                    Console.WriteLine($"Карточка {paymentItem.Key}. {paymentItem.Value.ToString()}");
                }
                else
                {
                    Console.WriteLine(paymentItem.Value.ToString());
                }
            }
            Console.WriteLine("==================================");
        }

    }
}
