// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
namespace HomeWork5
{
    class Task01
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(5, 11);
            int[] array = new int[n];
            RandomArray(n, array);
            Console.WriteLine();
            EvenNumbers(n, array);
        }
        public static void RandomArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(100, 1000);
                Console.Write($"({array[i]}) ");
            }
        }
        public static void EvenNumbers(int n, int[] array)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count = count + 1;
                }
            }
            Console.Write($"Количество четных чисел в массиве: {count}");
        }
    }
}
