/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void GetNumberOfRow(int[,] matrix)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[0, j];
    }
    int min = sum;
    int minI = 0;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < min)
        {
            min = sum;
            minI = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Number of row with minimal sum is {minI + 1}");
}


Console.WriteLine("Insert number of rows:");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number of columns:");
int columnsNumber = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(rowsNumber, columnsNumber);
PrintMatrix(matrix);
Console.WriteLine();
GetNumberOfRow(matrix);