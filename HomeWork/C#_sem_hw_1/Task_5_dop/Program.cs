// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.Пример: 456 -> 6 
Console.Clear();
Console.WriteLine("Введите целое трёхзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int number2 = Math.Abs(number1) % 10;
if(Math.Abs(number1) / 100 >= 1 && Math.Abs(number1) / 1000 < 1)
{
    Console.WriteLine($"Последняя цифра числа {number1}: {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не подходит");
}
