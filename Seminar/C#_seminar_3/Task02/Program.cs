// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер четверти от 1 до 4: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int max = int.MaxValue;
            int min = int.MinValue;
            Result(x, max, min);
        }    
        public static void Result(int x, int max, int min)
        {        
            if (x == 1)
            {
                Console.WriteLine($"Координата X от 0 до {max}. Координата Y от 0 до {max} ");
            }
            else if (x == 2) 
            {
                Console.WriteLine($"Координата X от 0 до {min}. Координата Y от 0 до {max} ");
            }
            else if (x == 3)
            {
                Console.WriteLine($"Координата X от 0 до {min}. Координата Y от 0 до {min} ");
            }
            else if (x == 4)
            {
                    Console.WriteLine($"Координата X от 0 до {max}. Координата Y от 0 до {min} ");
            }                                                           
            else 
            {
                Console.WriteLine("Число от 1 до 4!!!");
            }
        }
    }
}
