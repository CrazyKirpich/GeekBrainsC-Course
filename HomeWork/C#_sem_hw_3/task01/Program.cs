// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 12821 -> да; 14212 -> нет
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число:");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            string str = a.ToString();
            Palindrome(str);
        }
        public static void Palindrome(string str)
        {
            if (str.Length < 6 && str.Length > 4)
            {
                if (str[0] == str[4] && str[1] == str[3])
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
            }
            else
            {
                Console.WriteLine("Число не пятизначное");
            }
        }
    }
}
