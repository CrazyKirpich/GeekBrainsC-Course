// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого элемента в массиве нет

namespace HomeWork7
{
    class Task2
    {
        public static void Main(string[] args)
        {
            try
            {
                int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
                int[,] randomArray = FillRandomArray(newArray);
                PrintArray(randomArray);
                Console.WriteLine();
                Console.WriteLine("Введите номер ряда");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер столбца");
                int column = Convert.ToInt32(Console.ReadLine());
                FindElementInArray(row, column, randomArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неправильные данные");
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

        public static void FindElementInArray(int row, int column, int[,] randomArray)
        {
            if (row < randomArray.GetLength(0) && column < randomArray.GetLength(1))
            {
                Console.WriteLine($"Array[{row}, {column}] = {randomArray[row, column]}");
            }
            else
            {
                Console.WriteLine("Такого элемента в массиве не существует.");
            }
        }
    }
}
