// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
namespace HelloWorld
{
    class Program
    {   public static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string? str =  Convert.ToString(Console.ReadLine());
            if (str == null || str.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет.");
            }
            else
            {
                string number = str.ToString();
                Console.WriteLine($"{number} -> {number[2]}");               
            }
        }
    }
}
