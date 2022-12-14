/***************************************************************************************
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
***************************************************************************************/
/*
int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join("|", array));
Console.WriteLine($"В массиве [{String.Join("|", array)}] {EverNum(array)} четных элементов");

int EverNum(int[] Arr)
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
*/
/***************************************************************************************
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
***************************************************************************************/
/*
int[] array = GetArray(5, -50, 50);
Console.WriteLine(String.Join("|", array));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве [{String.Join("|", array)}] равна {EverSum(array)}");

int EverSum(int[] Arr)
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += Arr[i];
        }
    }
    return count;
}
*/
/***************************************************************************************
Задача 38: 
Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
***************************************************************************************/

int[] array = GetArray(5, -200, 200);
Console.WriteLine(String.Join("|", array));
Console.WriteLine($"Разница между максимальным и минимальным значениями массива: [{String.Join("|", array)}] равна { DifDeduction(array)}");

int DifDeduction(int[] Arr)
{
    int i = 0;
    int max = Arr[i];
    int min = Arr[i];
    int ded = 0;
    while (i < Arr.Length)
    {
        if (Arr[i] > max)
        {
            max = Arr[i];
        }
        if (Arr[i] < min)
        {
            min = Arr[i];
        }
        i++;
    }
    ded = max - min;
    return ded;
}



// Метод заполнения массива:
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}