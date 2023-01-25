// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

(int, bool) CheckError(string? CheckText)
{
    if (CheckText == null || CheckText.Trim() == "")
    {
        Console.WriteLine("Некорректный ввод! Повторите попытку.");
        Console.Write("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
        return (0, true);
    }
    return (int.Parse(CheckText), false);
}

(int x, int y, int z) GetValue(string? text)
{
    (int num, bool error) x = (0, true);
    (int num, bool error) y = (0, true);
    (int num, bool error) z = (0, true);
    while (x.error || y.error || z.error == true)
    {
        Console.Clear();
        Console.WriteLine(text);
        Console.Write("x: ");
        x = CheckError(Console.ReadLine());
        if (x.error == true) continue;
        Console.Write("y: ");
        y = CheckError(Console.ReadLine());
        if (y.error == true) continue;
        Console.Write("z: ");
        z = CheckError(Console.ReadLine());
        if (z.error == true) continue;
    }
    Console.Clear();
    (int, int, int) result = (x.num, y.num, z.num);
    return result;
}

void CountDistance((int x, int y, int z) firstDot,(int x, int y, int z) secondDot)
{
    double distance = Math.Pow((secondDot.x - firstDot.x), 2);
    distance += Math.Pow(((secondDot.y - firstDot.y)), 2);
    distance += Math.Pow((((secondDot.z - firstDot.z))), 2);
    distance = Math.Round(Math.Sqrt(distance), 2);
    Console.WriteLine($"A({firstDot.x},{firstDot.y},{firstDot.z}); B({secondDot.x},{secondDot.y},{secondDot.z}) -> {distance}");
}

Console.Clear();
(int x, int y, int z) firstDot = GetValue("Введите координаты для первой точки: ");
(int x, int y, int z) secondDot = GetValue("Введите координаты для второй точки: ");
CountDistance(firstDot, secondDot);