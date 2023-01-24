// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrom(string box)
{
    for (int first = 0, last = box.Length - 1; first < last; ++first, --last)
    {
        if (box[first] != box[last])
        {
            return false;
        }
    }
    return true;
}

void Choice(bool val, string box)
{
    if (val == true)
        Console.WriteLine($"{box} -> да");
    else
        Console.WriteLine($"{box} -> нет");
}

string InputVal()
{
    Console.Write("Введите число: ");
    return Console.ReadLine();
}

string box = InputVal();
Choice(IsPalindrom(box), box);
