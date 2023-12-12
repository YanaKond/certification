// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string rec(int M, int N)
{
    if (M == N)
        return $"{N} ";
    if(M < N)
        return rec(M, N - 1) + $"{N} ";
    else
        return rec(M, N + 1) + $"{N} ";
}

Console.WriteLine(rec(M, N));