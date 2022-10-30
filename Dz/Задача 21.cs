// Задача 21
//
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distances(double coordinateX1, double coordinateY1, double coordinateZ1, double coordinateX2,
    double coordinateY2, double coordinateZ2)
{
    double distances = Math.Sqrt((coordinateX2 - coordinateX1) * (coordinateX2 - coordinateX1) +
                                 (coordinateY2 - coordinateY1) * (coordinateY2 - coordinateY1) +
                                 (coordinateZ2 - coordinateZ1) * (coordinateZ2 - coordinateZ1));
    return distances;
}

Console.WriteLine("Введите координату Х первой точки");
double coordinateX1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y первой точки");
double coordinateY1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z первой точки");
double coordinateZ1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Х второй точки");
double coordinateX2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y второй точки");
double coordinateY2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z второй точки");
double coordinateZ2 = double.Parse(Console.ReadLine()!);


double distances = Distances(coordinateX1,coordinateY1,coordinateZ1,coordinateX2,coordinateY2,coordinateZ2);
Console.WriteLine($"Расстояние между точками равно {distances}");