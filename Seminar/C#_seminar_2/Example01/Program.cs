namespace HelloWorld
{
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
// 78 -> 8
// 12 -> 2
// 85 -> 8
    class Program
    {
        public static void Main(string[] args)
        {
            int number = GetRandomNumber(10, 100); // Вызов метода и получение результата от метода
            Console.WriteLine("Number: " + number);
            string str = number.ToString();     // Приведение number к строке(string)
            int result = Convert.ToInt32(str[0].ToString()); // В новую переменную записываем первую цифру числа (нулевой элемент массива)
            for (int i = 1; i < str.Length; i++)
            {
                if (result < Convert.ToInt32(str[i].ToString()))
                {
                    result = Convert.ToInt32(str[i].ToString());
                }
            }
            Console.WriteLine("Result: " + result);
        }
        public static int GetRandomNumber(int first, int second) // Объявляем функцию(метод). <Тип данных возвращаемого значения> <Имя функции> (<Параметры>)
        {
            int number = new Random().Next(first, second); // Получаем случайное число от first включительно, до second невключительно.
            return number; // Возвращаем занчение.
        }






















    }
























}