/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76*/

int[] CreatArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(-10, 100);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int Max(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

Console.Write("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArray(size);
int max=Max(array);
int min=Min(array);
int result=max-min;


ShowArray(array);
Console.Write($"Разницу между максимальным и минимальным элементов массива = {result}");