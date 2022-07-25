// 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// 1 4 7 2      1 5 8 5
// 5 9 2 3      4 9 4 2
// 8 4 2 4      7 2 2 6
// 5 2 6 7      2 3 4 7

namespace Seminar8
{
    class Task2
    {
        public static void Main(string[] args)
        {
            int[,] newArray = new int[new Random().Next(5, 7), new Random().Next(5, 7)];
            int[,] randomArray = FillRandomArray(newArray);
            Console.Clear();
            PrintArray(randomArray);
            Console.WriteLine();
            if (randomArray.GetLength(0) == randomArray.GetLength(1))
            {
                SwitchRowAndColumns(randomArray);
                PrintArray(randomArray);
            }
            else
            {
                Console.WriteLine("Невозможно заменить строки на столбцы для данного массива");
            }
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

        public static int[,] SwitchRowAndColumns(int[,] randomArray)
        {

            for (int i = 0; i < randomArray.GetUpperBound(0); i++) // Array.GetUpperBound(0) - выдает максимальный номер элемента в столбце(элемент последней строки).
            {                                                      // Array.GetUpperBound(1) - выдает максимальный номер элемента в строке(элемент последнего столбца).
                for (int j = i + 1; j < randomArray.GetLength(0); j++)
                {
                    int temporary = randomArray[i, j];
                    randomArray[i, j] = randomArray[j, i];
                    randomArray[j, i] = temporary;
                }
            }
            return randomArray;
        }
    }
}
