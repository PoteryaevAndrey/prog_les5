/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
*/

int[] CreatArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 999);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int PositiveOfnumber(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter += 1;
        }
    }
    return counter;
}
Console.Write("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreatArray(size);
int result = PositiveOfnumber(array);
ShowArray(array);
Console.Write($"Колличество четных элементов в массиве {result}");
