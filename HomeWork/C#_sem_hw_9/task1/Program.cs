// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 4; N = 8. -> ""4, 6, 7, 8""

using System.Collections.Generic;
using System.Linq;
using System;
using MyMistake;
using MySequenceArray;
using MyPrint;

namespace Homework9
{
    class Task1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Задайте значение M");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Задайте значение N");
                int n = Convert.ToInt32(Console.ReadLine());
                if (m != n)
                {
                    int[] sequenceArray = SequenceArray.FillSequenceArray(m, n); 
                    Console.WriteLine();
                    PrintArrays.PrintArray(sequenceArray);
                }
                else
                {
                    Mistake.MistakeFound();
                    Main(new string[] { "" });
                }
            }
            catch (FormatException)
            {
                Mistake.MistakeFound();
                Main(new string[] { "" });
            }
        }
    }
}
