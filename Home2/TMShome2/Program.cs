static int fact(int n)
{
    if (n == 1 || n == 0)
        return 1;
    return n * fact(n - 1);
}

Console.Write("Enter number for factorial: ");

if (int.TryParse(Console.ReadLine(), out var num))
{
    int fact_num = fact(num);
    Console.WriteLine($"{num}! = {fact_num}");
}
else
{
    Console.WriteLine("You entered a strong number!");
}

Console.ReadKey();