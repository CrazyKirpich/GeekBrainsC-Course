// Урок 4. Двумерные массивы и рекурсия.

// Пример двумерного массива: int[,] matrix = new int[5,8]; - где 5 - число строк, а 8 - число столбцов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - показывает количество строк.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - показывает количество столбцов.
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    } 
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }     
    }
}

int[,] matrix = new int[3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
