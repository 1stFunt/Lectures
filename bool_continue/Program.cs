﻿/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

while (true) //лучше вместо true - переменную bool
{
    int x = ReadInt("Введите точку x: ");
    int y = ReadInt("Введите точку y: ");

    if (x == 0 || y == 0)
    {
        Console.WriteLine("x и y не могут быть равны 0");
        continue; //return, если нет цикла
    }

    if (x > 0 && y > 0)
    {
        Console.WriteLine("1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4");
    }
    break; //если использовалась переменная bool, то вместо break - название переменной = false
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Второй пример. Bool в методе.
int lineA = ReadInt("Введите сторону A: ");
int lineB = ReadInt("Введите сторону B: ");
int lineC = ReadInt("Введите сторону C: ");

if (CheckSide(lineA, lineB, lineC) && CheckSide(lineB, lineA, lineC) && CheckSide(lineC, lineB, lineA))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
bool CheckSide(int checkSide, int a, int b) //метод bool
{
    return checkSide < a + b;
}