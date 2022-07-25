namespace HelloWorld
{
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4. 16, 4 -> кратно
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 == 0)
            { 
                Console.WriteLine("Делить на 0 нельзя");   
            }
            else
            {
                int result = Remainder(number1, number2);
                if (result == 0)
                {
                    Console.WriteLine($"Число {number1} кратно числу {number2}");
                }
                else
                {
                Console.WriteLine($"Число {number1} не кратно числу {number2}, отаток равен {result}");
                }
            }
        }
        public static int Remainder(int number1, int number2)
        {
            int result = number1 % number2;
            return result;
        }
    }
}