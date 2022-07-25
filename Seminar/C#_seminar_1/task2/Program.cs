// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");    
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}"); 
}
