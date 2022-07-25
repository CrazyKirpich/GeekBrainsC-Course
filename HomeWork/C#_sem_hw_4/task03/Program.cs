// Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]; 6, 1, 33 -> [36, 1, 1089]
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(5, 11);
            int[] array = new int[n];
            RandomArray(n, array);
            Console.WriteLine();
            PowArray(n, array);
        }
        public static void RandomArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(1, 41);
                Console.Write(array[i] + " ");
            }
        }
        public static void PowArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = (int)Math.Pow(array[i], 2);
                Console.Write(array[i] + " ");
            }
        }
    }
}
