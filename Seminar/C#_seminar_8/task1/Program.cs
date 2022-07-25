// 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// 1 4 7 2      8 4 2 4 
// 5 9 2 3      5 9 2 3 
// 8 4 2 4      1 4 7 2

namespace Seminar8
{
    class Task1
    {
        public static void Main(string[] args)
        {
            int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
            int[,] randomArray = FillRandomArray(newArray);
            Console.Clear();
            PrintArray(randomArray);
            Console.WriteLine();
            SwitchRowFirstToLast(randomArray);
            PrintArray(randomArray);
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
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    Console.Write($"{randomArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] SwitchRowFirstToLast(int[,] randomArray)
        {

            for (int i = 0; i < randomArray.GetLength(1); i++)
            {
                for (int j = 0; j < randomArray.GetLength(0) / 2; j++)
                {
                    int temporary = randomArray[j, i];
                    randomArray[j, i] = randomArray[randomArray.GetUpperBound(0) - j, i];
                    randomArray[randomArray.GetUpperBound(0) - j, i] = temporary;
                }
                // int temporary = randomArray[0, i];
                // randomArray[0, i] = randomArray[randomArray.GetUpperBound(0), i];
                // randomArray[randomArray.GetUpperBound(0), i] = temporary;
            }
            return randomArray;
        }
    }
}
