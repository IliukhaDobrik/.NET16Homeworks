namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            DictionaryActions actions = new DictionaryActions();

            do
            {
                PrintMenu();

                actions = Enum.Parse<DictionaryActions>(Console.ReadLine());

                switch (actions)
                {
                    case DictionaryActions.Add:
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter grade: ");
                            int grade = int.Parse(Console.ReadLine());

                            if (dictionary.TryAdd(name, grade))
                            {
                                Console.WriteLine("***Student was added!***");
                            }
                            else
                            {
                                Console.WriteLine("***Student with this name wasn't added!***");
                            }

                            break;
                        }
                    case DictionaryActions.Change:
                        {
                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine("***This dictionary is empty! Add new students firstly!***");

                                break;
                            }
                            else
                            {
                                Console.Write("Enter name: ");
                                string name = Console.ReadLine();

                                Console.Write("Enter a new grade: ");
                                int grade = int.Parse(Console.ReadLine());

                                if (dictionary.ContainsKey(name))
                                {
                                    dictionary[name] = grade;
                                    Console.WriteLine("***Grade was changed!***");
                                }
                                else
                                {
                                    Console.WriteLine("***We can't find a student with this name!***");
                                }

                                break;
                            }
                        }
                    case DictionaryActions.Remove:
                        {
                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine("***This dictionary is empty! Add new students firstly!***");

                                break;
                            }
                            else
                            {
                                Console.Write("Enter name: ");
                                string name = Console.ReadLine();

                                if (dictionary.ContainsKey(name))
                                {
                                    dictionary.Remove(name);
                                    Console.WriteLine("***Student was removed!***");
                                }
                                else
                                {
                                    Console.WriteLine("***We can't find a student with this name!***");
                                }

                                break;
                            }
                        }
                    case DictionaryActions.SeeAll:
                        {
                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine("***This dictionary is empty! Add new students firstly!***");

                                break;
                            }
                            else
                            {
                                Console.WriteLine("All students: ");
                                Console.WriteLine("-----");

                                foreach (var item in dictionary)
                                {
                                    Console.WriteLine(item.Key + " - " + item.Value);
                                }

                                Console.WriteLine("-----");

                                break;
                            }
                        }
                    case DictionaryActions.Calculate:
                        {
                            double mean = 0;

                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine($"***Arifmetic mean: {mean}***");

                                break;
                            }
                            else
                            {
                                foreach (var item in dictionary)
                                {
                                    mean += item.Value;
                                }

                                mean /= dictionary.Count;

                                Console.WriteLine($"***Arifmetic mean: {mean}***");

                                break;
                            }
                        }
                    case DictionaryActions.SeeBest:
                        {
                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine("***This dictionary is empty! Add new students firstly!***");

                                break;
                            }
                            else
                            {
                                int maxGrade = 0;
                                string name = string.Empty;

                                foreach (var item in dictionary)
                                {
                                    if (item.Value > maxGrade)
                                    {
                                        maxGrade = item.Value;
                                        name = item.Key;
                                    }
                                }

                                Console.WriteLine($"***The best student is: {name} - {maxGrade}***");

                                break;
                            }
                        }
                    case DictionaryActions.See8:
                        {
                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine("***This dictionary is empty! Add new students firstly!***");

                                break;
                            }
                            else
                            {
                                Console.WriteLine("***Students with a grade of 8 or highter: ***");

                                string name = string.Empty;

                                foreach (var item in dictionary)
                                {
                                    if (item.Value >= 8)
                                    {
                                        Console.WriteLine(item.Key + " - " + item.Value);
                                        name = item.Key;
                                    }
                                }

                                if (string.IsNullOrEmpty(name))
                                {
                                    Console.WriteLine("***We don't have a student with grade of 8 or highter :(***");
                                }

                                break;
                            }
                        }
                    case DictionaryActions.See4:
                        {
                            if (dictionary.Count == 0)
                            {
                                Console.WriteLine("***This dictionary is empty! Add new students firstly!***");

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Students with a grade of 4 or less: ");

                                string name = string.Empty;

                                foreach (var item in dictionary)
                                {
                                    if (item.Value <= 4)
                                    {
                                        Console.WriteLine(item.Key + " - " + item.Value);
                                        name = item.Key;
                                    }
                                }

                                if (string.IsNullOrEmpty(name))
                                {
                                    Console.WriteLine("***We don't have a student with grade of 4 or less :)***");
                                }

                                break;
                            }
                        }
                    case DictionaryActions.Finish:
                        {
                            Console.WriteLine("***Summer is here!!! Holidays!!!***");

                            dictionary.Clear();

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("***You entered a strong number!***");

                            break;
                        }
                }
            }
            while (actions != DictionaryActions.Finish);
        }

        static void PrintMenu()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Press 1 if you want to add a new person");
            Console.WriteLine("Press 2 if you want to change a grade");
            Console.WriteLine("Press 3 if you want to remove a student");
            Console.WriteLine("Press 4 if you want to see all the students");
            Console.WriteLine("Press 5 if you want to calculate an arifmetic mean");
            Console.WriteLine("Press 6 if you want to see the best students");
            Console.WriteLine("Press 7 if you want to see students with a grade of 8 or highter");
            Console.WriteLine("Press 8 if you want to see students with a grade of 4 or less");
            Console.WriteLine("Press 9 if you want to finished a program");
            Console.WriteLine("======================");
        }
    }
}