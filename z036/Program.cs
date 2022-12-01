/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
*/

int[] CreatArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(-50, 100);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int SumPositiveOddPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.Write("Введите размер желаемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArray(size);
int result=SumPositiveOddPos(array);
ShowArray(array);
Console.Write($"Сумма элементов стоящих на нечетных местах в масииве = {result}");
