// Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9


int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1,A(n,m-1));
}
Console.WriteLine("введите число m ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число n ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(A(n, m));