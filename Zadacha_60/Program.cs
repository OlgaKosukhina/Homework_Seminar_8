﻿/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

int[,,] InitMatrix(int depth, int row, int columns)
{
    int[,,] matrix = new int[depth, row, columns];

    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                matrix[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i} {j} {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Insert depth of matrix:");
int depth = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number of rows:");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number of columns:");
int columnsNumber = int.Parse(Console.ReadLine());
int[,,] matrix = InitMatrix(depth, rowsNumber, columnsNumber);
PrintMatrix(matrix);