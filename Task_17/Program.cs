// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите значение x:");
// int x = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение y:");
// int y = int.Parse(Console.ReadLine());

// if(x > 0 && y >0);

// if(x > 0 && y > 0) Console.WriteLine("1-я четверть");

// if(x < 0 && y > 0) Console.WriteLine("2-ая четверть");

// if(x < 0 && y < 0) Console.WriteLine("3-я четверть");

// if(x > 0 && y < 0) Console.WriteLine("4-ая четверть");


Console.WriteLine("Введите значение x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y:");
int y = int.Parse(Console.ReadLine());

string quarter = Quarter(x, y);
Console.WriteLine(quarter);


string Quarter(int x, int y)
{
    string result = string.Empty;
    if(x > 0 && y > 0)
    {
        result = "Координаты относятся к 1-й четверти";
    }
    if(x < 0 && y > 0)
    {
        result = "Координаты относятся к 2-й четверти";
    }
    if(x < 0 && y < 0)
    {
        result = "Координаты относятся к 3-й четверти";
    }
    if(x > 0 && y < 0)
    {
        result = "Координаты относятся к 4-й четверти";
    }
    return result;
}






















