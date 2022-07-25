// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

namespace HomeWork8
{
    class Task5
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            // работает для любой размерности массива
            int[,] newArray = new int[new Random().Next(4, 5), new Random().Next(4, 5)];
            int[,] spiralArray = FillArraySpiral(newArray);
            PrintArray(spiralArray);
        }

        public static int[,] FillArraySpiral(int[,] array)
        {
            int row = 0;
            int column = 0;
            int count = 1;
            int rowLength = array.GetLength(1);
            int columnLength = array.GetLength(0);
            while (rowLength > 0 && columnLength > 0)
            {
                for (int i = column; i <= column + rowLength - 1; i++)
                {
                    array[row, i] = count++;
                }
                for (int i = row + 1; i <= row + columnLength - 1; i++)
                {
                    array[i, column + rowLength - 1] = count++;
                }
                for (int i = column + rowLength - 2; i >= column; i--)
                {
                    array[row + columnLength - 1, i] = count++;
                }
                for (int i = row + columnLength - 2; i >= row + 1; i--)
                {
                    array[i, column] = count++;
                }
                row++;
                column++;
                rowLength -= 2;
                columnLength -= 2;
            }
            return array;
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

