﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
Console.WriteLine("--------------Задача №54.--------------");
int rows = 4;
int columns = 4;
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("---------");
SortSting(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortSting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
Console.WriteLine("--------------Задача №56.--------------");
int rows1 = 5;
int columns1 = 4;
int[,] arr = GetArray(rows1, columns1, 0, 10);
PrintArray(arr);
Console.WriteLine($"Строка (по индексу) с наименьшей суммой элементов - {StringMinSum(arr)}");

int StringMinSum(int[,] arr)
{
    int result = 0;
    int minsum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minsum += arr[0,i];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            result = i;
        }
    }
    return result;
}

// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

Console.WriteLine("Введите колличество строк 1 массива");
int rowsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов 1 массива");
int columnsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество строк 2 массива");
int rowsB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов 2 массива");
int columnsB = int.Parse(Console.ReadLine()!);
if (columnsA != rowsB)
{
    Console.WriteLine("Данные матрицы нельзя умножать.");
    return;
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine("--------");
PrintArray(B);
Console.WriteLine("--------");
PrintArray(MultiplicationMatrix(A,B));

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}