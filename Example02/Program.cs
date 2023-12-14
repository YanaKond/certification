// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    int result = 0;
    if(m == 0)
        result = n + 1;
    if(m > 0 && n == 0)
        result = Akkerman(m - 1, 1);
    if(m > 0 && n > 0)
        result = Akkerman(m - 1, Akkerman(m, n - 1));
    return result;
}
Console.WriteLine(Akkerman(m, n));