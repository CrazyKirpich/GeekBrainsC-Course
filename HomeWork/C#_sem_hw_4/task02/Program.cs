// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            string str = a.ToString();
            int[] n = new int[str.Length];
            Sum(n, str);
        }
        public static void Sum(int[] n, string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {

                n[i] = Convert.ToInt32(str.Substring(i, 1));
                sum = sum + n[i];
            }
            Console.WriteLine(sum);
        }
    }
}