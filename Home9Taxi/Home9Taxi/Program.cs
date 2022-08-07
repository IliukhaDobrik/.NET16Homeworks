namespace Home9Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cash cash = new Cash();
            cash.Notify += DisplayMessage;
            //Console.WriteLine(cash.ToString());

            cash.AddMoney(15);
            //Console.WriteLine(cash.ToString());

            //Console.WriteLine(cash.IsPaymentPossible(13));
            //Console.WriteLine(cash.IsPaymentPossible(17));

            cash.MakePayment(10);
            //Console.WriteLine(cash.ToString());

            cash.MakePayment(16);
            //Console.WriteLine(cash.ToString());

            //Console.WriteLine(cash.AmountOfMoney);


            //User user = new User("Ilya", "Dobrinskiy", "+375298732839");
            //user.ToUpCash(100);
            //user.AddCard("Belinvest", new Card() { CardNumber = "3267" });
            //user.ToUpCard("Belinvest", 200);
            //user.ShowAvailablePaymentMethods();



            Console.ReadKey();
        }

        static void DisplayMessage(string message) => Console.WriteLine(message);
    }
}