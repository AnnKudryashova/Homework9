//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

int m = 0;
int n = 3;

int FunctionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkkerman(m - 1, 1);
  else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.WriteLine(FunctionAkkerman(m,n));