// 2. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

namespace GB
{
    public class Seminar5
    {
        public static void Main(string[] args)
        {
            int [] array = new int[new Random().Next(5, 11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintArray(CopyArray(array));
        }
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = new Random().Next(0, 21);
            }
        }
        public static void PrintArray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static int[] CopyArray(int[] array)
        {
            int[] copyArray = new int[array.Length];
            for (int i = 0; i <copyArray.Length; i++)
            {
                copyArray[i] = array[i];
            }
            return copyArray;
        }
    }
}