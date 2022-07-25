// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// 1 4 7 2      1 2 4 7
// 5 9 2 3      2 3 5 9
// 8 4 2 4      2 4 4 8

namespace HomeWork8
{
    class Task1
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
            Console.WriteLine();
            SortColumnsMinToMax(randomArray);
            PrintArray(randomArray);
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

        public static int[,] SortColumnsMinToMax(int[,] randomArray)
        {
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetUpperBound(1); j++)
                {
                    int minPosition = j;
                    for (int k = j + 1; k < randomArray.GetLength(1); k++)
                    {
                        if (randomArray[i, k] < randomArray[i, minPosition])
                        {
                            minPosition = k;
                        }
                    }
                    int temporary = randomArray[i, j];
                    randomArray[i, j] = randomArray[i, minPosition];
                    randomArray[i, minPosition] = temporary;
                }
            }
            return randomArray;
        }
    }
}
