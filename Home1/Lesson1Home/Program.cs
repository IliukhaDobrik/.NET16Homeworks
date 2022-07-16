static void example1()
{
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(-num);
}

static void example2()
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    for (int i = num1; i <= num2; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

static void example3()
{
    int count = int.Parse(Console.ReadLine());
    int lenth_m = int.Parse(Console.ReadLine());
    int width_сm = int.Parse(Console.ReadLine());

    int all_lenth_cm;

    all_lenth_cm = (count - 1) * lenth_m * 100 + (count - 2) * width_сm;

    Console.WriteLine(all_lenth_cm);
}

Console.WriteLine("First example: ");
example1();

Console.WriteLine("Second example: ");
example2();

Console.WriteLine("Third example: ");
example3();

Console.ReadLine();