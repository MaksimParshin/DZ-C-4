//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] ArrayRnd(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


void EvenNumber(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine(count);
}

EvenNumber(ArrayRnd(5));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void OddSum(int[] arr)
{
    int count = 0;

    for (int i = 1; i < arr.Length; i = i + 2)
    {
        count += arr[i];
    }
    Console.WriteLine(count);
}


OddSum(ArrayRnd(5));

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] arr1 = {3, 7, 22, 2, 78};

void SortArr(int[] arr)
{
    Array.Sort(arr1);
    Console.WriteLine(arr1[arr1.Length - 1] - arr1[0]);
}

SortArr(arr1);