using ConsoleApp4;

Work work = new();
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Получить все числа которые встречаюстя в массиве не чётное количество раз");
    Console.WriteLine($"2) Получить все числа которые встречаюстя в массиве чётное количество раз");
    Console.WriteLine($"3) Презапустить меню позволяет изменить создаваемый массив");
    Console.WriteLine();
}
void UseMenu()
{
    int[] userArray = {};
    Console.WriteLine($"Хотите ли вы создать свой массив 1)да. 2)нет.");
    string choice = Console.ReadLine();
    bool checkChoice = int.TryParse(choice, out var resultchoice);
    if (resultchoice == 1)
    {
        userArray = work.CreateUserArray();
        Console.WriteLine($"Массив создан");
    }
        while (true)
        {
            GetMenu();
            string enter = Console.ReadLine();
            bool checkenter = int.TryParse(enter, out var resultenter);
            Console.WriteLine();
            int[] ints = new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 4, 3 };
            if (resultenter == 1)
            {
                Console.WriteLine($"1)Использовать свой массив");
                Console.WriteLine($"2)Использовать заранее созданный в программе массив");
                string choiceuser = Console.ReadLine();
                bool check = int.TryParse(choiceuser, out var resultuser);
                if (resultuser == 1)
                {
                    work.OddNumber(userArray);
                }
                else if (resultuser == 2)
                {
                    work.OddNumber(ints);

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Такого пункта нет в меню");
                    Console.WriteLine();
                }
                continue;
            }
            else if (resultenter == 2)
            {
                Console.WriteLine($"1)Использовать свой массив");
                Console.WriteLine($"2)Использовать заранее созданный в программе массив");
                string choiceuser = Console.ReadLine();
                bool check = int.TryParse(choiceuser, out var resultuser);
                if (resultuser == 1)
                {
                    work.EvenNumber(userArray);
                }
                else if (resultuser == 2)
                {
                    work.EvenNumber(ints);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Такого пункта нет в меню");
                    Console.WriteLine();
                }
                continue;
            }
            else if (resultenter == 3)
            {
                UseMenu();
            }
            else
            {
                Console.WriteLine($"Выберите пункт меню");
            }
        }    
}
UseMenu();