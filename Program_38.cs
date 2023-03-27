/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = CreateArray(4);

PrintArray(array);

Console.Write($"-> {Math.Abs(Max(array)) - Math.Abs(Min(array))}");

double[] CreateArray(int size, int min = -10, int max = 10)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max) * 0.1; // нужно ли задавать вещественное число??
    return array;
}

void PrintArray(double[] array, string title = " ")
{
    if (title != " ")
        Console.Write($"{title}\n");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}