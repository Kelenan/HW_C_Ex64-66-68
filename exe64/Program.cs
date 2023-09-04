/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine(num);


string a1 = GetNatur (num, 1);

Console.WriteLine("-----");
Console.WriteLine(a1);



string GetNatur (int startNum, int inNum)
{
    if (startNum == 1) return inNum.ToString();
    return startNum + " " + GetNatur(startNum-1, inNum);
}

