namespace Home9Taxi
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            var taxiPark = new List<ITaxi>
            {
                new Car("1111", 7.6, "Серая", "Fiat"),
                new Motorbike("2222", 3.2, false, 600),
                new Helicopter("3333", 16.7, false, 1200)
            };

            User user = new User("Илья", "Добринский", "+375298732839");

            int response = 0;

            while (response != 4)
            {
                PrintMenu();
                response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        {
                            Console.Write("Введите название карты: ");
                            string cardName = Console.ReadLine();

                            Console.Write("Введите код карты (****): ");
                            string cardNumber = Console.ReadLine();

                            user.AddCard(cardName, new Card() { CardNumber = cardNumber});

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите название карты: ");
                            string cardName = Console.ReadLine();

                            Console.Write("Введите количество денег: ");
                            double amountOfMoney = double.Parse(Console.ReadLine());

                            user.ToUpCard(cardName, amountOfMoney);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Доступные транспортные средсва: ");

                            int i = 1;
                            foreach (var taxi in taxiPark)
                            {
                                Console.WriteLine($"{i++} -- {taxi.ToString()}");
                            }

                            Console.Write("Какой транспорт вы выбрали? ");
                            int userChoise = int.Parse(Console.ReadLine());

                            double price = taxiPark[userChoise -1].GetPriceOfRide();

                            Console.WriteLine("Выберете способ оплаты: ");
                            user.ShowAvailablePaymentMethods();
                            string nameOfPaymentMethod = Console.ReadLine();

                            try
                            {
                                if (user.PaymentMethod[nameOfPaymentMethod].IsPaymentPossible(price))
                                {
                                    user.PaymentMethod[nameOfPaymentMethod].MakePayment(price);
                                    user.ToUpPoint(5);
                                    taxiPark[userChoise - 1].MakeRide(user);
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег!");
                                }
                            }
                            catch (KeyNotFoundException)
                            {
                                Console.WriteLine("У вас нет такой карты! Ваши средства оплаты: ".ToUpper());
                                user.ShowAvailablePaymentMethods();
                            }

                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели недоступную операцию");
                            break;
                        }
                }
            }

            Console.ReadKey();
        }

        static void PrintMenu()
        {
            Console.WriteLine("Нажмите 1, если вы хотите добавить карту" + Environment.NewLine
                + "Нажмите 2, если хотите пополнить карту" + Environment.NewLine
                + "Нажмите 3, если хотите совершить поездку" + Environment.NewLine 
                + "Нажмите 4, если вы хотите выйти");
        }
    }
}