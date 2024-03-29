﻿using System.Threading;

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

            UserAction response = UserAction.Wait;

            Console.WriteLine("Добро пожаловать в приложение BestTaxi");

            while (response != UserAction.Exit)
            {
                PrintMenu();
                response = Enum.Parse<UserAction>(Console.ReadLine());

                switch (response)
                {
                    case UserAction.AddCard: 
                        {
                            Console.Write("Введите название карты: ");
                            string cardName = Console.ReadLine();

                            Console.Write("Введите код карты (****): ");
                            string cardNumber = Console.ReadLine();

                            user.AddCard(cardName, new Card() { CardNumber = cardNumber});

                            break;
                        }
                    case UserAction.ToUpCard:
                        {
                            Console.Write("Введите название карты: ");
                            string cardName = Console.ReadLine();

                            Console.Write("Введите количество денег: ");
                            double amountOfMoney = double.Parse(Console.ReadLine());

                            user.ToUpCard(cardName, amountOfMoney);

                            break;
                        }
                    case UserAction.MakeRide:
                        {
                            UserMakeRide(user, taxiPark);

                            break;
                        }
                    case UserAction.ShowFreeTaxi:
                        {
                            PrintFreeTaxi(taxiPark);

                            break;
                        }
                    case UserAction.ToUpCash:
                        {
                            Console.Write("Введите сумму найденных денег: ");
                            double amountOfMoney = double.Parse(Console.ReadLine());

                            user.ToUpCash(amountOfMoney);

                            break;
                        }
                    case UserAction.ShowAvailablePaymentMethods: 
                        {
                            user.ShowAvailablePaymentMethods();

                            break;
                        }
                    case UserAction.MakePayment:
                        {
                            Console.Write("Сколько стоит эта фигня? ");
                            double cost = double.Parse(Console.ReadLine());

                            Console.WriteLine("Выберете способ оплаты: ");
                            user.ShowAvailablePaymentMethods();
                            string nameOfPaymentMethod = Console.ReadLine();

                            try
                            {
                                GetDiscount(user, ref cost);

                                if (user.PaymentMethod[nameOfPaymentMethod].IsPaymentPossible(cost))
                                {
                                    user.PaymentMethod[nameOfPaymentMethod].MakePayment(cost);
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
                    case UserAction.RemoveCard:
                        {
                            Console.Write("Введите название карты: ");
                            string removeCard = Console.ReadLine();

                            user.DeleteCard(removeCard);

                            break;
                        }
                    case UserAction.ToUpPoint:
                        {
                            Console.WriteLine("Вы можете: " + Environment.NewLine
                                + "Нажмите 1, если хотите поработать" + Environment.NewLine
                                + "Нажмите 2, если хотите прогуляться" + Environment.NewLine
                                + "Нажмите 3, если хотите покататься на такси(Находится на стадии разработки)");
                            int userResponse = int.Parse(Console.ReadLine());
                            
                            switch (userResponse)
                            {
                                case 1: //поработать
                                    {
                                        Console.Write("Сколько быллов вы хотите? (не больше 30) ");
                                        int points = int.Parse(Console.ReadLine());

                                        if (points >= 0 && points < 10)
                                        {
                                            Work(300);

                                            user.ToUpPoint(points);
                                        }
                                        else if (points >= 10 && points < 20)
                                        {
                                            Work(600);

                                            user.ToUpPoint(points);
                                        }
                                        else if (points >= 20 && points <= 30)
                                        {
                                            Work(900);

                                            user.ToUpPoint(points);
                                        }

                                        break;
                                    }
                                case 2: //прогуляться
                                    {
                                        Walk(user);

                                        break;
                                    }
                                case 3: //такси
                                    {
                                        UserMakeRide(user, taxiPark);

                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }

                            break;
                        }
                    case UserAction.Walk:
                        {
                            Walk(user);

                            break;
                        }
                    case UserAction.ShowAmountOfPoint:
                        {
                            if (user.PaymentMethod.ContainsKey("Point"))
                            {
                                var points = ((Point)user.PaymentMethod["Point"]);
                                Console.WriteLine(points.ToString());
                            }

                            break;
                        }
                    case UserAction.Exit:
                        {
                            Console.WriteLine("Заходите в наше приложение ещё. Хорошего дня!");

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
            Console.WriteLine("****************************************");
            Console.WriteLine("Нажмите 1, если  хотите добавить карту" + Environment.NewLine
                + "Нажмите 2, если хотите пополнить карту" + Environment.NewLine
                + "Нажмите 3, если хотите совершить поездку" + Environment.NewLine 
                + "Нажмите 4, если хотите увидеть список свободного транспорта" + Environment.NewLine
                + "Нажмите 5, если хотите попонить кошелёк" + Environment.NewLine
                + "Нажмите 6, если хотите посмотреть сколько у вас денег" + Environment.NewLine
                + "Нажмите 7, если хотите потратить денег" + Environment.NewLine
                + "Нажмите 8, если хотите выкинуть карточку" + Environment.NewLine
                + "Нажмите 9, если хотите заработать баллов" + Environment.NewLine
                + "Нажмите 10, если хотите погулять" + Environment.NewLine
                + "Нажмите 11, если хотите узнать, сколько у васс баллов" + Environment.NewLine
                + "Нажмите 12, если хотите выйти");
            Console.WriteLine("****************************************");
        }

        static void PrintFreeTaxi(in List<ITaxi> taxiPark)
        {
            Console.WriteLine("Доступные транспортные средсва: ");

            int i = 1;
            foreach (var taxi in taxiPark)
            {
                Console.WriteLine($"{i++} -- {taxi.ToString()}");
            }
        }

        static double GetDiscount(in User user, ref double price)
        {
            double discount = 0;
            if (user.PaymentMethod.ContainsKey("Point"))
            {
                discount = ((Point)user.PaymentMethod["Point"]).AmountOfMoney;
            }

            if (discount != 0)
            {
                if (price >= discount)
                {
                    price -= discount;
                    ((Point)user.PaymentMethod["Point"]).MakePayment(discount);
                }
                else
                {
                    price = 0;
                    ((Point)user.PaymentMethod["Point"]).MakePayment(price);
                }
            }

            return discount;
        }

        static void UserMakeRide(in User user, in List<ITaxi> taxiPark)
        {
            PrintFreeTaxi(taxiPark);

            Console.Write("Какой транспорт вы выбрали? ");
            int userChoise = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберете способ оплаты: ");
            user.ShowAvailablePaymentMethods();
            string nameOfPaymentMethod = Console.ReadLine();

            try
            {
                double price = taxiPark[userChoise - 1].GetPriceOfRide();

                double discountOfMoney = GetDiscount(user, ref price);

                if (user.PaymentMethod[nameOfPaymentMethod].IsPaymentPossible(price))
                {
                    if (user.PaymentMethod.ContainsKey("Point"))
                    {
                        ((Point)user.PaymentMethod["Point"]).AddPoints(5);
                    }

                    user.PaymentMethod[nameOfPaymentMethod].MakePayment(price);
                    taxiPark[userChoise - 1].MakeRide(user);
                }
                else
                {
                    user.ToUpPoint(discountOfMoney * 3);
                    Console.WriteLine("У вас недостаточно денег!");
                }
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("У вас нет такой карты! Ваши средства оплаты: ".ToUpper());
                user.ShowAvailablePaymentMethods();
            }
        }

        static void Work(int milisecond)
        {
            Console.WriteLine("Работы на каторгах");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(milisecond);
                Console.Write(". ");
            }

            Console.WriteLine();
        }

        static void Walk(in User user)
        {
            Console.WriteLine($"{user.FirstName} решил прогуляться по улице");
            user.ToUpPoint(3);
        }
    }

   
}