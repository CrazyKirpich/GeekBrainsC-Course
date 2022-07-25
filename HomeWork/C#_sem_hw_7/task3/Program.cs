// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace HomeWork7
{
    class Task3
    {
        public static void Main(string[] args)
        {
            int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
            Console.WriteLine();
            PrintAverageColumnElements(randomArray);
        }

        public static int[,] FillRandomArray(int[,] newArray)
        {
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    newArray[i, j] = new Random().Next(1, 10);
                }
            }
            return newArray;
        }

        public static void PrintArray(int[,] randomArray)
        {
            Console.WriteLine("Дан массив:");
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    Console.Write($"{randomArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintAverageColumnElements(int[,] randomArray)
        {
            double average = 0;
            for (int i = 0; i < randomArray.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < randomArray.GetLength(0); j++)
                {
                    sum += randomArray[j, i];
                }
                average = sum / randomArray.GetLength(0);
                Console.WriteLine($"Cреднее арифметическое элементов в {i + 1} столбце: {Math.Round(average, 3)}");
            }
        }
    }
}
