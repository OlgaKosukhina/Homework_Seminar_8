/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random randomizer = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetNewMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tmp;
                }
            }
            newMatrix[i, j] = matrix[i, j];
        }
    }
    return newMatrix;
}



Console.WriteLine("Insert number of rows");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number of columns");
int columnsNumber = int.Parse(Console.ReadLine());
int[,] oldMatrix = InitMatrix(rowsNumber, columnsNumber);
PrintArray(oldMatrix);
Console.WriteLine();
int[,] newMatrix = GetNewMatrix(oldMatrix);
PrintArray(newMatrix);