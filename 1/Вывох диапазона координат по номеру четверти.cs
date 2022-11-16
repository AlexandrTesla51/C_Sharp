// Напишите программу, которая принимает на вход
// координаты точки(X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

// int GetNumberOfPlane(int coordX, int coordY)
// {
//     if (coordX == 0 || coordY == 0) return -1;
//     if (coordX > 0 && coordY > 0) return 1;
//     if (coordX < 0 && coordY > 0) return 2;
//     if (coordX < 0 && coordY < 0) return 3;
//     else return -1;
// }
//
// int coordX = -19, coordY = 20;
// int numberOfPlane = GetNumberOfPlane(coordX, coordY);
// Console.WriteLine($"Номер плоскости: {numberOfPlane}");

void CoordinateRange(int QuarterNumber)
{
    if (QuarterNumber == 1) Console.WriteLine("x=(0;+infinity) y=(0;+infinity)");
    else if (QuarterNumber == 2) System.Console.WriteLine("x=(-infinity;0) y=(0;+infinity)");
    else if (QuarterNumber == 3) System.Console.WriteLine("x=(-infinity;0) y=(-infinity;0)");
    else if (QuarterNumber == 4) System.Console.WriteLine("x=(0;+infinity) y=(-infinity;0)");
    else System.Console.WriteLine("Неверный номер четверти");
}

Console.WriteLine("Введите номер четверти");
int QuarterNumber=int.Parse(Console.ReadLine()!);
CoordinateRange(QuarterNumber);