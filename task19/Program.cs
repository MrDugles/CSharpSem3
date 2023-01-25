// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrom(string inputText)
{
    for (int first = 0, last = inputText.Length - 1; first < last; ++first, --last)
    {
        if (inputText[first] != inputText[last])
        {
            return false;
        }
    }
    return true;
}

void PrintResult(bool val, string inputText)
{
    if (val == true)
        Console.WriteLine($"{inputText} -> да");
    else
        Console.WriteLine($"{inputText} -> нет");
}

string InputVal()
{
    Console.Write("Введите число: ");
    return Console.ReadLine();
}

string inputText = InputVal();
PrintResult(IsPalindrom(inputText), inputText);