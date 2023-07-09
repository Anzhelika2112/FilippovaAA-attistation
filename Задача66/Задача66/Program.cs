// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите начальное число: ");
int start = int.Parse(Console.ReadLine()??""); 

Console.Write("Введите конечное число: ");
int end = int.Parse(Console.ReadLine()??""); 

GetSum(start, end, 0);

void GetSum(int m, int n, int sum)
{
    if (m > n) 
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    GetSum(m, n, sum);
}

