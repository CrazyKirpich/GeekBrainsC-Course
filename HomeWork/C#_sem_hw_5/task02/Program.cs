// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
namespace HomeWork5
{
    class Task02
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(5, 11);
            int[] array = new int[n];
            RandomArray(n, array);
            Console.WriteLine();
            SumUnevenElem(n, array);
        }
        public static void RandomArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(-20, 21); // было записано array[i] = new Random().Next(int.MinValue, int.MaxValue); Но для удобства восприятия ограничил диапозон.
                Console.Write($"({array[i]}) ");
            }
        }
        public static void SumUnevenElem(int n, int[] array)
        {
            int sum = 0;
            for (int i = 1; i < n; i += 2)
            {
                sum = sum + array[i];
            }
            Console.Write($"Сумма элементов, стоящих на нечетных позициях: {sum}");
        }
    }
}
