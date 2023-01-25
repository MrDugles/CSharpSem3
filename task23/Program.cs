/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

double CubeOfNumber(int number)
{
    return Math.Pow(number, 3);
}

void FetchCubes(int number)
{
    Console.Write("Таблица кубов чисел: ");
    for (int i = 1; i < number; i++)
    {
        Console.Write(CubeOfNumber(i) + ", ");
    }
    Console.Write(CubeOfNumber(number));
}


int GetNumber(string promptText)
{
    Console.Write(promptText + ": ");
    string? strNum = Console.ReadLine();
    if (strNum == null || strNum.Trim() == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(strNum);
}

int number = GetNumber("Введите натуральное число");

FetchCubes(number);