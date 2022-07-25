//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
double number3 = Convert.ToDouble(Console.ReadLine());
double max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное из трех чисел: {max}");
