// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76
namespace HomeWork5
{
    class Task03
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(5, 11);
            double[] array = new double[n];
            RandomArray(n, array);
            Console.WriteLine();
            Difference(n, array);
        }
        public static void RandomArray(int n, double[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = Math.Round(new Random().NextDouble() * (100 - (-100)) + (-100), 2); // рандом ограничил (-100; 100) и 2 знака после запятой - для удобства визуализации.
                Console.Write($"({array[i]}) ");
            }
        }
        public static void Difference(int n, double[] array)
        {

            double min = array[0];
            double max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"{max} - ({min}) = {Math.Round((max - min), 2)}");
        }
    }
}
