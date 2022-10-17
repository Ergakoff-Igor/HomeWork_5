/***************************************************************************************
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
***************************************************************************************/

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