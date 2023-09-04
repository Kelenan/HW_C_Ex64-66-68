﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Clear();

Console.Write("Введите число M: ");
int numM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"{numM} / {numN}");

Console.WriteLine(GetAkkerman (numM, numN));

int GetAkkerman(int m, int n)
    {
        if (m == 0) return n+1;
        if (m > 0 && n == 0) return GetAkkerman(m - 1, 1);
        if (m > 0 && n > 0) return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
        return 0;
    }

