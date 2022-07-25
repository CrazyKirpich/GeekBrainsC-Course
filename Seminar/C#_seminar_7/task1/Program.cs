// 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.    0 1 2 3   1 2 3 4   2 3 4 5

namespace Seminar7
{
    class Task1
    {
        public static void Main(string[] args)
        {
            int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
        }

        public static void PrintArray(int[,] randomArray)
        {
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    Console.Write($"{randomArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] FillRandomArray(int[,] newArray)
        {
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    newArray[i, j] = i + j;
                }
            }
            return newArray;
        }
    }
}
