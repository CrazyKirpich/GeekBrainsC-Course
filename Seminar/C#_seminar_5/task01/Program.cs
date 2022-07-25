// 1. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// Размер массива от 5 до 10. Числа в массива от -20 до 20. [-4, -8, 8, 2] -> [4, 8, -8, -2] 
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            
            int count = new Random().Next(5, 11);
            int[] arrayNumber = new int[count];
            Console.WriteLine("Первоначальный массив: ");
            FillArray(arrayNumber);
            Console.WriteLine();
            Console.WriteLine("Перевернутый массив: ");
            PrintChangeArray(arrayNumber);
        }
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-20, 21);
                Console.Write($"{array[i]} ");
            }
        }
        public static void PrintChangeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * -1;
                Console.Write($"{array[i]} ");
            }
        }
    }
}
