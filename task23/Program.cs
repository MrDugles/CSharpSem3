// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double SetCube(int val)
{
    return Math.Pow(val, 3);
}

void GetCube(int number)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i < number; i++)
    {
        Console.Write(SetCube(i) + ", ");
    }
    Console.Write(SetCube(number));
}

int SetVal()
{
    Console.Write($"Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = SetVal();
GetCube(num);