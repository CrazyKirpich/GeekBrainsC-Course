// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

namespace HomeWork7
{
    class Task1
    {
        public static void Main(string[] args)
        {
            double[,] newArray = new double[new Random().Next(3, 6), new Random().Next(3, 6)];
            double[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
        }

        public static double[,] FillRandomArray(double[,] newArray)
        {
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    newArray[i, j] = Math.Round(new Random().NextDouble() * (20 - (-20)) + (-20), 1);
                }
            }
            return newArray;
        }

        public static void PrintArray(double[,] randomArray)
        {
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    Console.Write($"[{randomArray[i, j]}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
