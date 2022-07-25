// Задача 58: Задайте две матрицы. Напишите программу, 
// которая выведет матрицу произведения элементов двух предыдущих матриц.
// 1 4 7 2     1 5 8 5     1 20 56 10
// 5 9 2 3     4 9 4 2     20 81 8 6
// 8 4 2 4     7 2 2 6     56 8 4 24
// 5 2 6 7     2 3 4 7     10 6 24 49

namespace HomeWork8
{
    class Task3
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int n = new Random().Next(3, 6);
            int[,] newArray1 = new int[n, n];
            int[,] matrix1 = FillRandomArray(newArray1);
            PrintArray(matrix1);
            Console.WriteLine();
            int[,] newArray2 = new int[n, n];
            int[,] matrix2 = FillRandomArray(newArray2);
            PrintArray(matrix2);
            Console.WriteLine();
            int[,] newArray3 = new int[n, n];
            int[,] multiMatrix = MultiplicateTwoMatrix(matrix1, matrix2, newArray3);
            PrintArray(multiMatrix);
        }

        public static int[,] FillRandomArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
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

        public static int[,] MultiplicateTwoMatrix(int[,] randomArray1, int[,] randomArray2, int[,] newArray3)
        {
            for (int i = 0; i < newArray3.GetLength(0); i++)
            {
                for (int j = 0; j < newArray3.GetLength(1); j++)
                {
                    newArray3[i, j] = randomArray1[i, j] * randomArray2[i, j];
                }
            }
            return newArray3;
        }
    }
}


