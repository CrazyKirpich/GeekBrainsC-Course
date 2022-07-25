// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число, обозначающее день недели(1-7): ");
            int i = Convert.ToInt32(Console.ReadLine());
            Holiday(i);
        }
        public static void Holiday(int i)
        {   
            if (i > 0 && i < 8)
            {
                if (i < 6)
                {
                    Console.WriteLine("Нет");  
                }
                else
                {
                    Console.WriteLine("Да");
                }
            }    
            else
            {
                Console.WriteLine("Число не подходит");
            }    
        }
    }
}