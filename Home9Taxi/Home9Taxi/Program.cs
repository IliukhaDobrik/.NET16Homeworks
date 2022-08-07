namespace Home9Taxi
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Илья", "Добринский", "+375298732839");
            user.ToUpCash(10);
            user.ToUpPoint(30);

            user.ToUpCard("Белинвест", 27);

            //тут я могу воспользоваться NotifyHandler
            user.AddCard("Белинвест", new Card() { CardNumber = "1639" });

            user.ToUpCard("Белинвест", 27);

            user.ShowAvailablePaymentMethods();

            Console.ReadKey();
        }
    }
}