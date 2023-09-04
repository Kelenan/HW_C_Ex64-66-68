/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.Write("Введите число M: ");
int numM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"{numM} / {numN}");

 if (numM > numN)
{
  int tmp = numM;
  numM = numN;
  numN = tmp;  
} 

int sum1 = 0;
sum1 = GetNatur(numM, numN);

Console.WriteLine("-----");
Console.WriteLine(sum1);


int GetNatur (int numM, int numN)
{
    if (numM == 0 && numN == 0) return 0;
    if (numM == 1 && numN == 1) return 1;
    if (numM > numN) return sum1;
    return numM + GetNatur(numM+1, numN);
}

