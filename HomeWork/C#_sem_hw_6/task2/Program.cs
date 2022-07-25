// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

namespace HomeWork6
{
    class Task2
    {
        public static void Main(string[] args)
        {
            try
            {
                
                // double [] array = new double[4];
                // for (int i = 0; i < array.Length; i++)
                // {
                //     Console.WriteLine("Введите число:");
                //     array [i] = Convert.ToDouble(Console.ReadLine());
                // }

                Console.WriteLine("Введите значение b1:");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение k1:");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение b2:");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение k2:");
                double k2 = Convert.ToDouble(Console.ReadLine());
                if (k1 == k2)
                {
                    Console.WriteLine("Прямые паралельны");
                }
                else
                {
                    double x = (b2 - b1) / (k1 - k2);
                    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
                    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Math.Round(x, 3)}; {Math.Round(y, 3)})");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неправильные данные");
                Main(new string[] { "" });
            }
        }
    }
}
