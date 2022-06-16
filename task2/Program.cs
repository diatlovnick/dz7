/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[] GetSearch(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    string[] array = str.Split(",");
    int[] arraySearch = new int[array.Length];
    if (array.Length == 2)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            if (int.TryParse(array[i], out int number))
            {
                arraySearch[i] = number;
            }
            else
            {
                Console.WriteLine($"неправильный ввод, {message} ");
            }

        }
    }
    else
    {
        Console.WriteLine($"неправильный ввод, {message} ");
    }     
    return arraySearch;
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

void PrintArray(int [] array)
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

int[] arraySearch = GetSearch("введите позицию элемента через запятую, где первое число номер строки, второе число номер столбца, например: 2, 3");
//PrintArray(arraySearch);
if (arraySearch[0] <= row && arraySearch[1] <= col )
    Console.WriteLine(resultMatrix[arraySearch[0],arraySearch[1]]);
else
{
    Console.WriteLine("Такого элемента нет");
}




