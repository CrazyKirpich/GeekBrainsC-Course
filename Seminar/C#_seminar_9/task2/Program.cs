// Задача 2. Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты
// 1 4 7 2      1 4 7 2
// 5 9 2 3      5 81 2 9
// 8 4 2 4      8 4 2 4
// Кажется в примере ошибка

namespace Seminar9
{
    class Task2
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int[,] newArray = new int[new Random().Next(4, 6), new Random().Next(4, 6)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
            Console.WriteLine();
            PowElementsWithEvenPositions(randomArray);
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

        public static int[,] PowElementsWithEvenPositions(int[,] randomArray)
        {
            for (int i = 0; i < randomArray.GetLength(0); i += 2)
            {
                for (int j = 0; j < randomArray.GetLength(1); j += 2)
                {
                    randomArray[i, j] = (int)Math.Pow(randomArray[i, j], 2);
                }
            }
            return randomArray;
        }
    }
}
