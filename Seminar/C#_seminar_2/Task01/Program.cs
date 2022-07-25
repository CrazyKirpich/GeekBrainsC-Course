namespace HelloWorld
{
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46
    class Program
    {
        public static void Main(string[] args)
        {
            int number = GetRandomNumber();
            string str = number.ToString();
            Console.WriteLine($"{number} -> {str.Remove(1, 1)}");
        }
        public static int GetRandomNumber()
        {   
            int number = new Random().Next(100, 1000);
            return number; 
        }
    }
}