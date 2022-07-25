//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите любое число");
double number_N = Convert.ToDouble(Console.ReadLine());
Console.Clear();
double number_intN = 0;
double nubmer_i = 1;
if(number_N > 0)
{
    number_intN = number_N - number_N % 1;
}
else
{
    number_intN = number_N + number_N % 1;
}
if(number_intN < 0)
{
    while(nubmer_i > number_N)
    {
        if(nubmer_i % 2 == 0)
        {
            Console.WriteLine(nubmer_i);
            nubmer_i = nubmer_i - 1;
        }
        else
        {
            nubmer_i = nubmer_i - 1;
        }
    }
}
else
{
    while(nubmer_i < number_N)
    {
        if(nubmer_i % 2 == 0)
        {
            Console.WriteLine(nubmer_i);
            nubmer_i = nubmer_i + 1;
        }
        else
        {
            nubmer_i = nubmer_i + 1;
        }
    }    
}
