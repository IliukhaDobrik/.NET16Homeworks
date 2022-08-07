namespace Home9Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ilya", "Dobrinskiy", "+375298732839");
            user.ToUpCash(100);
            //user.ToUpCard("Belinvest", 100);
            user.ShowAvailablePaymentMethods();

            Console.ReadKey();
        }
    }
}