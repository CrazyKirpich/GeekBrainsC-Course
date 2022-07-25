//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double number2 = Convert.ToDouble(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} большее, числа {number2}");
}
if (number1 < number2)
{
    Console.WriteLine($"Число {number2} большее, числа {number1}");
}
if (number1 == number2)
{
    Console.WriteLine($"Число {number2} и {number1} равны");
}
