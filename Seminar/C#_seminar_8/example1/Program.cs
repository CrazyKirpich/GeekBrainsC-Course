using System.Collections.Generic;
using System.Linq;
using System;

namespace Seminar7
{
    class Program
    {
        /// <summary> Основной метод программы </summary> // так делается описание к чему-то конкретному.
        public static void Main(string[] args)
        {

            Point p1 = new Point(5, 5);

            Person tom = new Person("Tom");

            Console.WriteLine(tom.Name);
        }


        // arrayNumbers.Add(p1);
        // Point p2 = new Point() { X = 1, Y = 1 };

        // Fillist(arrayNumbers, 5);

        // // List<Point> program = new List<Point>();
        // // Point[] programList = new Point[5];

        // foreach (int number in arrayNumbers) // для каждого элемента number в массиве list. Цикл за нас создает переменную number и прогоняет все значения list.
        // // нюанс в том, что в переменную number ничего нельзя записать в ручную, как если бы мы создали переменную вручную. Переменная только на вывод.
        // {
        //     Console.Write(number + " ");
        // }
        // Console.WriteLine();
        // // List имеет множество очень полезных методов
        // int num = arrayNumbers.Find(x => x % 2 == 0); //  объявляем, что в list есть параметр x и дальше задаем тело функции, которая будет искать, что нам нужно. Выводит первое совпадение.
        // // foreach (int x in list) // равносильно методу Find;
        // // {
        // //     if (x % 2 == 0)
        // //     {
        // //         num = x;
        // //         break;
        // //     }
        // // }
        // Console.WriteLine(num);

        // List<int> evenNumList = arrayNumbers.FindAll(x => x % 2 == 0); // выводит все совпадения.
        // foreach (int x in evenNumList)
        // {
        //     Console.Write(x + "");
        // }


        /// <summary> Заполнение коллекции List<int> случайными числами от 0 до 10 </summary>
        /// <param name="list">List<int> для заполнения заначениями </param>
        /// <param name="count">List<int> количество случайных значений </param>
        public static void Fillist(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(new Random().Next(0, 11));
            }
        }


        public class Person // класс человек
        {
            public Person(string name) // конструктор класса
            {
                _name = name;
            }
            private string _name;
            public string Name
            {
                get
                {
                    return _name;
                }
            }
        }

        public class Point // задаем новый класс.
        {
            public Point(int x, int y) // Конструктор, это Метод, который назван так же, как и класс.
            {
                X = x;
                Y = y;
                Console.WriteLine("X = " + X + ", Y = " + Y);
            }
            public int X; // Переменные в классе называются ПОЛЯМИ и пишутся с большой буквы.
            public int Y;
        }
    }
}


