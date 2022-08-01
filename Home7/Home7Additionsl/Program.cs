namespace Home7Additionsl
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(16,7);
            Fraction fraction1 = new Fraction(2,3);

            double res = Fraction.Parse(fraction);
            double res1 = (double)fraction1;

            Console.WriteLine($"{fraction} = {res}");
            Console.WriteLine($"{fraction1} = {res1}");

            //fraction = Fraction.ReduceFraction(fraction);

            //if (Fraction.TryReduceFraction(fraction, out Fraction reduceFraction))
            //{
            //    Console.WriteLine(reduceFraction);
            //}
            //else
            //{
            //    Console.WriteLine("We cannot reduced this fraction!");
            //}

            Fraction result = fraction + fraction1;
            Console.WriteLine($"{fraction} + {fraction1} = {result}");

            result = fraction - fraction1;
            Console.WriteLine($"{fraction} - {fraction1} = {result}");

            result = fraction * fraction1;
            Console.WriteLine($"{fraction} * {fraction1} = {result}");

            result = fraction / fraction1;
            Console.WriteLine($"{fraction} / {fraction1} = {result}");

            Console.ReadKey();
        }
    }
}