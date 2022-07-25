//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число");
double number1 = Convert.ToDouble(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1} является четным");
}
else
{
    Console.WriteLine($"Число {number1} не является четным");
}