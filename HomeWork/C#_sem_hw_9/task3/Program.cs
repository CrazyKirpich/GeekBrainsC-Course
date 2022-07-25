// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
// m = 2, n = 3 -> A(m,n) = 29

using System.Collections.Generic;
using System.Linq;
using System;
using MyMistake;

namespace Homework9
{
    class Task3
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Задайте неотрицательное значение M");
                uint m = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Задайте неотрицательное значение N");
                uint n = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AckermannCalculation(m, n)}");
            }
            catch (OverflowException)
            {
                Mistake.MistakeFound();
                Main(new string[] { "" });
            }
            catch (FormatException)
            {
                Mistake.MistakeFound();
                Main(new string[] { "" });
            }
        }

        public static uint AckermannCalculation(uint m, uint n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if ((m != 0) && (n == 0))
            {
                return AckermannCalculation(m - 1, 1);
            }
            else
            {
                return AckermannCalculation(m - 1, AckermannCalculation(m, n - 1));
            }
        }
    }
}

