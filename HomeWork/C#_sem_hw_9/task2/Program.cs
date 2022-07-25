// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 4; N = 8. -> 30

using System.Collections.Generic;
using System.Linq;
using System;
using MyMistake;
using MySequenceArray;

namespace Homework9
{
    class Task2
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
                int[] sequenceArray = SequenceArray.FillSequenceArray(m, n);
                int sumElements = SumElementsFromTo(sequenceArray);
                Console.WriteLine();
                Console.WriteLine($"M = {m}, N = {n} -> {sumElements}");
            }
            catch (FormatException)
            {
                Mistake.MistakeFound();
                Main(new string[] { "" });
            }
        }

        public static int SumElementsFromTo(int[] sequenceArray)
        {
            int sumElements = 0;
            for (int i = 0; i < sequenceArray.Length; i++)
            {
                sumElements += sequenceArray[i];
            }
            return sumElements;
        }
    }
}
