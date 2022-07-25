// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

using System.Collections.Generic;
using System.Linq;
using System;

namespace HomeWork8
{
    class Task4
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int[,,] newArray = new int[new Random().Next(2, 5)
                                       , new Random().Next(2, 5)
                                       , new Random().Next(2, 5)];
            HashSet<int> numbers = new HashSet<int>();
            int[,,] randomArray = FillRandomUniqueThreeDimensionalArray(newArray, numbers);
            PrintThreeDimensionalArray(randomArray);
        }

        public static int GenerateUniqueNumber(HashSet<int> numbers)
        {
            while (true)
            {
                int n = new Random().Next(10, 100);
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);
                    return n;
                }
            }
        }

        public static int[,,] FillRandomUniqueThreeDimensionalArray(int[,,] newArray
                                                                    , HashSet<int> numbers)
        {
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    for (int k = 0; k < newArray.GetLength(2); k++)
                    {
                        newArray[i, j, k] = GenerateUniqueNumber(numbers);
                    }

                }
            }
            return newArray;
        }

        public static void PrintThreeDimensionalArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]} ({i}, {j}, {k})    ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
