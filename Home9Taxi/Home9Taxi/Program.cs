namespace Home9Taxi
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ilya", "Dobrinskiy", "+375298732839");
            user.ToUpCash(100);
            user.ToUpPoint(30);



            Console.ReadKey();
        }
    }
}