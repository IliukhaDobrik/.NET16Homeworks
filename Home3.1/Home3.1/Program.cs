Console.Write("Enter number A: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter number B: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter number C: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > 100 && num2 > 100)
{
    Console.WriteLine("A > 100 && B < 100");
}
if (num1 % 2 == 0 || num2 % 2 == 0)
{
    Console.WriteLine("A % 2 == 0 || B % 2 == 0");
}
if (num1 > 0 || num2 > 0)
{
    Console.WriteLine("A > 0 || B > 0");
}
if (num1 % 3 == 0 && num2 % 3 == 0 && num3 % 3 == 0)
{
    Console.WriteLine("A % 3 == 0 && B % 3 == 0 && C % 3 == 0");
}
if (num1 < 50 || num2 < 50 || num3 < 50)
{
    Console.WriteLine("A < 50 || B < 50 || C < 50");
}
if (num1 < 0 || num2 < 0 || num3 < 0)
{
    Console.WriteLine("A < 0 || B < 0 || C < 0");
}

Console.ReadKey();