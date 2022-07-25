// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                PrintSquare(i);
            }
        }
        public static void PrintSquare(int n)
        {
            Console.WriteLine(n * n * n);
        }
    }
}
