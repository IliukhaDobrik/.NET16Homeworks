Console.Write("Enter size of massive: ");

if (int.TryParse(Console.ReadLine(), out int size))
{
    int[] ints = new int[size];

    //ReadLine
    for (int i = 0; i < ints.Length; i++) 
    {
        ints[i] = int.Parse(Console.ReadLine());
    }

    //Amount
    //int amount = ints.Sum<int>(x =>
    //{
    //    if(x%2==0)
    //    {
    //        return 0;
    //    }

    //    return x;
    //});
    int amount = 0;
    for (int i = 1; i < ints.Length; i = i + 2)
    {
        amount += ints[i];
    }
    Console.WriteLine($"Amount is: {amount}");

    //Min
    //int min = ints.Min();
    int min = ints[0];
    foreach (int item in ints)
    {
        if (item < min)
        {
            min = item;
        }
    }
    Console.WriteLine($"Min item is: {min}");
}
else
{
    Console.WriteLine("You enterred a strong number!");
}

////////////////////

int[] ints1 = new int[10];
Random random = new Random();

for (int i = 0; i < ints1.Length; i++)
{
    ints1[i] = random.Next(100);
}

foreach (int item in ints1) 
{
    Console.Write(item + " ");
}

Console.WriteLine();

////////////////////

Stack<int> stack = new Stack<int>();

for(int i = 0; i < ints1.Length; i++)
{
    stack.Push(ints1[i]);
}

int stack_size = stack.Count;
for (int i = 0; i < stack_size; i++)
{
    Console.WriteLine(stack.Pop() + " ");
}

Console.ReadKey();