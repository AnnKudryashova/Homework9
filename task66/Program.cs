// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNaturalsDigits(int n, int m)
{
    if (n == m) return n;
    else return SumNaturalsDigits(n, m-1) + m;
}

int n = 4;

int m = 8; 

Console.WriteLine(SumNaturalsDigits(n,m));
