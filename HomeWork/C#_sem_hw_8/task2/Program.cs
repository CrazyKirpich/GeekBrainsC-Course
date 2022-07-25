// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// 1 4 7 2  => 1 строка
// 5 9 2 3
// 8 4 2 4  
// 5 2 6 7

namespace HomeWork8
{
    class Task2
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
            Console.WriteLine();
            FindColumnWithMinSumElem(randomArray);
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

        public static void FindColumnWithMinSumElem(int[,] randomArray)
        {
            int numMin = 0;
            int sumMin = Int32.MaxValue;
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                int sumColumn = 0;
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    sumColumn = sumColumn + randomArray[i, j];
                }
                if (sumColumn < sumMin)
                {
                    sumMin = sumColumn;
                    numMin = i + 1;
                }
            }
            // в примере к заданию нулевая строка названа первой, 
            //поэтому при выводе у меня 2 варианта на всякий случай
            Console.WriteLine($"Наименьшая сумма элементов ({sumMin}) находится в {numMin}({numMin - 1}) строке.");
        }
    }
}
