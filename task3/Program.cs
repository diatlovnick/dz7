/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
double [] GetSumAverage(int [,] matrix)
{
    double sum = 0;
    double[] array = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = (matrix[i,j] + sum) / (i+1);
        }
        array[j] = sum;
    }
    return array;

}

int GetDemension(string message)
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int [,] InitMatrix(int row, int col)
{
    int [,] matrix = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        matrix[i, j] = rnd.Next(1,20);
    }

    return matrix;
}

void PrintArray(double [] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");

    }
}

void PrintMatrix(int [,] matrix)
{
    Console.WriteLine("Заполненная матрица");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");

    Console.WriteLine();
    }
}

int row = GetDemension("Введите длину для первого разряда матрицы:");
int col = GetDemension("Введите длину для второго разряда матрицы:");

int [,] resultMatrix = InitMatrix(row, col);
PrintMatrix(matrix: resultMatrix);
double [] array = GetSumAverage(resultMatrix);
PrintArray(array);