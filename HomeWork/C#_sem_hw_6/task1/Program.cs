// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 1, -7, 567, 89, 223-> 3

namespace HomeWork6
{
    class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел целые числа");
            string? str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                Console.WriteLine($"Чисел больше нуля: {Count(str)}");
            }
            else
            {
                Main(new string[] { "" });
            }
        }
        public static int Count(string str)
        {
            string[] nums = str.Split(' ');
            int[] n = new int[nums.Length];
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int parseNumber;
                bool result = Int32.TryParse(nums[i], out parseNumber);
                if (result == true)
                {
                    n[i] = parseNumber;
                    if (n[i] > 0)
                    {
                        count = count + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Неправильный ввод данных");
                    Environment.Exit(0);
                }
            }
            return count;
        }
    }
}
