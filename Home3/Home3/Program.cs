char operation;

do
{
    Console.Write("Enter first number: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.Write("Enter operations(+-/*) or 'escape' for finish: ");
    operation = Console.ReadKey(true).KeyChar;

    Console.WriteLine();

    switch (operation)
    {
        case '+':
            {
                int num3 = num1 + num2;
                Console.WriteLine($"{num1}+{num2}={num3}");
                break;
            }
        case '-':
            {
                int num3 = num1 - num2;
                Console.WriteLine($"{num1}-{num2}={num3}");
                break;
            }
        case '*':
            {
                int num3 = num1 * num2;
                Console.WriteLine($"{num1}*{num2}={num3}");
                break;
            }
        case '/':
            {
                int num3 = num1 / num2;
                Console.WriteLine($"{num1}/{num2}={num3}");
                break;
            }
        case '\u001b': //this is UTF-16 code 'Escape'
            {
                Console.WriteLine("Program finished!");
                break;
            }
        default:
            {
                Console.WriteLine("You entered a strong operations!");
                break;
            }
    }
}
while (operation != (char)ConsoleKey.Escape);

Console.ReadKey();