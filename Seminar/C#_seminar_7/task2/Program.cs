// 2. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//   1 4 7 2   5 9 2 3   8 4 2 4;  Сумма элементов главной диагонали: 1+9+2 = 12.

namespace Seminar7
{
    class Task2
    {
        public static void Main(string[] args)
        {
            int[,] newArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
            Console.WriteLine();
            int sum = SumDiagonalElement(randomArray);
            Console.WriteLine($"Cумма элементов, находящихся на главной диагонали: {sum}");
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
                    newArray[i, j] = new Random().Next(1, 10);
                }
            }
            return newArray;
        }

        public static int SumDiagonalElement(int[,] randomArray)
        {
            int sum = 0;
            int length = randomArray.GetLength(0);
            if (length > randomArray.GetLength(1))
            {
                length = randomArray.GetLength(1);
            }
            for (int i = 0; i < length; i++) // (int i = 0; i < randomArray.GetLength(0) && i < randomArray.GetLength(1); i++)
            {
                sum += randomArray[i, i];
            }
            return sum;
        }
    }
}
