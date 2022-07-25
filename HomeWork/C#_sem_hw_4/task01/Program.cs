// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Введите число A:");
            // double a = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Введите число B:");
            // double b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            // double sum = Math.Pow(a, b);
            // Console.WriteLine($"{a}, {b} -> {sum}");

            Console.WriteLine("Введите число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Pow(a, b);
        }
        public static void Pow(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine($"{a}, {b} -> 1");
            }
            else
            {
                int sum = a;
                for (int i = 1; i < b; i++)
                {
                    sum = sum * a;
                }
                Console.WriteLine($"{a}, {b} -> {sum}");
            }
        }
    }
}
// Два варианта - с готовым методом и с циклом.
