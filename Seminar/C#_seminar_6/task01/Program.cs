// 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). [1 2 3 4 5] -> [5 4 3 2 1]
// P.S. уходим от static в методе GetArray.
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
            PrintArray(ReverseArray(array));
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
        public static int[] ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for (int i = 0; i <reverseArray.Length; i++)
            {
                reverseArray[i] = array[array.Length - i - 1];
            }
            return reverseArray;
        }


        // public static void Main()
        // {
        //     Seminar5 seminar5 = new Seminar5();
        //     int[] array = seminar5.GetArray();
        //     Console.WriteLine("Исходный массив");
        //     PrintArray(array);
        //     Console.WriteLine();
        //     for (int i = 0; i < array.Length / 2; i++)
        //     {
        //         int a = array[i];
        //         array[i] = array[array.Length - i - 1];
        //         array[array.Length - i - 1] = a;
        //     }
        //     Console.WriteLine("Перевернутый массив");
        //     PrintArray(array);
        // }
        // public static void PrintArray(int[] arr)
        // {
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         Console.Write(arr[i] + " ");
        //     }
        // }
        // public int[] GetArray()
        // {
        //     Random random = new Random();
        //     int x = random.Next(5, 10);
        //     int[] arr = new int[x];
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         arr[i] = random.Next(0, 41);
        //     }
        //     return arr;
        // }
    }
}
