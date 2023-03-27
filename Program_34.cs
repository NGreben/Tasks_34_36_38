/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = CreateArray(4);

PrintArray(array);

Console.Write($"-> {CountPositiveNumb(array)}");

int[] CreateArray(int size, int min = 100, int max = 1000)
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

int CountPositiveNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}