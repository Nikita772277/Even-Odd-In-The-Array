using ConsoleApp4;

Work work = new();
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Получить все числа которые встречаюстя в массиве не чётное количество раз");
    Console.WriteLine($"2) Получить все числа которые встречаюстя в массиве чётное количество раз");
    Console.WriteLine($"3) Создать свой массив чисел");
    Console.WriteLine();
}
void UseMenu()
{
    while (true)
    {
        GetMenu();
        string enter = Console.ReadLine();
        bool check = int.TryParse(enter, out var result);
        Console.WriteLine();
        int[] ints = new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 4, 3 };
        if (result == 1)
        {
            work.OddNumber(ints);
            return;
        }
        else if (result == 2)
        {
            work.EvenNumber(ints);
            return;
        }
        else
        {
            Console.WriteLine($"Выберите пункт меню");
        }
    }
}
UseMenu();