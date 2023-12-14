// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();
Console.Write("Введите размер массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 101);
}
Console.WriteLine(string.Join(", ", array));

void RecurseArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        RecurseArray(array, index - 1);
    }
}

RecurseArray(array, array.Length - 1);