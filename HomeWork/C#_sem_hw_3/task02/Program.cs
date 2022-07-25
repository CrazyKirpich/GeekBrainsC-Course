// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
//A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Z1:");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Z2:");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double sum = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
            Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y1}, {z2}) -> {sum}");
        }
    }
}
// Болею, температура высокая - ничего умнее этого не придумал :)
