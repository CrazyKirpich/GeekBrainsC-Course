// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Result(x, y);
        }    
        public static void Result(int x, int y)
        {        
            if (x !=0 && y !=0 && x > 0 && y > 0 )
            {
                Console.WriteLine("Первая четверть");
            }
            else if (x !=0 && y !=0 && x < 0 && y > 0)
            {
                Console.WriteLine("Вторая четверть");
            }
            else if (x !=0 && y !=0 && x < 0 && y < 0)
            {
                Console.WriteLine("Третья четверть");
            }
            else if (x !=0 && y !=0 && x > 0 && y < 0)
            {
                Console.WriteLine("Четвертая четверть");
            }                                                           
            else 
            {
                Console.WriteLine("Координаты не подходят");
            }
        }
    }
}
