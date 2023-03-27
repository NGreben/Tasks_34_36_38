/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = CreateArray(4);

PrintArray(array);

Console.Write($"-> {Sum(array)}");

int[] CreateArray(int size, int min = -50, int max = 100)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max);
    return array;
}

void PrintArray(int[] array, string title = " ")
{
    if (title != " ")
        Console.Write($"{title}\n");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
    return sum;
}