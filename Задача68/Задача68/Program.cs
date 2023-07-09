// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()??""); 

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()??""); 


int akkermanFunction = Akk(m, n);

Console.Write($"m = {m}, n = {n} -> A(m,n) = {akkermanFunction} ");

int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}