/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/


int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int[,] GetMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            {
                newMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
            }
        }
    }
    return newMatrix;
}


Console.WriteLine("Insert number of rows:");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number of columns:");
int columnsNumber = int.Parse(Console.ReadLine());
int[,] firstMatrix = InitMatrix(rowsNumber, columnsNumber);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = InitMatrix(rowsNumber, columnsNumber);
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] newMatrix = GetMatrixMultiplication(firstMatrix, secondMatrix);
PrintMatrix(newMatrix);