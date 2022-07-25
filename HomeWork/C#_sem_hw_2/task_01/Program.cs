// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
namespace HelloWorld
{
    class Program
    {   public static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число: "); 
            string? str =  Convert.ToString(Console.ReadLine());
            if (str == null || str.Length < 2)
            {
                Console.WriteLine("Второй цифры нет.");
            }
            else
            {
                string number = str.ToString();
                Console.WriteLine($"{number} -> {number[1]}");               
            }
        }
    }
}
// Не делал проверки на положительное / отрицательное число, на то, что трёхзначное, на то, что целое или дробное и тд. Я как понял, сейчас это лишнее. Если нужно - могу сделать.