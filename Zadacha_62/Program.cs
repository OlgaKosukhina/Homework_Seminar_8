/*  Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = 0;
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

int[,] PrintNewMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int increment = 1;
    int offset = 0;
    int k = 1;

    for (offset = 0; increment <= matrix.GetLength(0) * matrix.GetLength(1); offset++)
    {
        for (int j = offset; j < matrix.GetLength(1) - offset; j++)
        {
            newMatrix[offset, j] = increment;
            increment++;
        }
        for (int i = offset + 1; i < matrix.GetLength(0) - offset; i++)
        {
            newMatrix[i, matrix.GetLength(0) - 1 - offset] = increment;
            increment++;
        }
        if (matrix.GetLength(0) - offset * 2 > 1)
        {
            for (int j = matrix.GetLength(1) - 2 - offset; j > offset; j--)
            {
                newMatrix[matrix.GetLength(0) - 1 - offset, j] = increment;
                increment++;
            }
        }
        if (matrix.GetLength(1) - offset * 2 > 1)
        {
            for (int i = matrix.GetLength(0) - 1 - offset; i > offset; i--)
            {
                newMatrix[i, offset] = increment;
                increment++;
            }
        }
    }
    offset++;

    return newMatrix;
}



Console.WriteLine("Insert rows numbers");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert columns numbers");
int columnsNumber = int.Parse(Console.ReadLine());
int[,] oldMatrix = InitMatrix(rowsNumber, columnsNumber);
Console.WriteLine();
int[,] newMatrix = PrintNewMatrix(oldMatrix);
PrintMatrix(newMatrix);
