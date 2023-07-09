//  Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число: ");
int start = int.Parse(Console.ReadLine()??""); 
int end = 1; 
GetNum(start, end); 

void GetNum(int start, int end)
{
    if(end > start)
    {
        return; 
    }
    else 
    {
        GetNum(start, end + 1); 
        Console.Write(end + ", "); 
    }
  
}