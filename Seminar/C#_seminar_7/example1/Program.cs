//

using System.Collections.Generic; // подключение коллекции к файлу
using System.Linq; //
using System;

namespace Seminar7
{
    class Example1
    {
        /// <summary> Основной метод программы </summary> // так делается описание к чему-то конкретному.
        public static void Main(string[] args)
        {
            // int[] a = new int[5] { 1, 2, 3, 4, 5 };
            // int[,] b = new int[2, 5] { { 1, 2, 3, 4, 5 }, {1, 2, 3, 4, 5} };
            List<int> list = new List<int>(); // List - метод из коллекции. Создает массив, который можно легко расширять и добавлять в него новые элементы.
            // list.Add(6);
            // list.Add(7);
            // list.Add(10);
            List<int> b = new List<int>();
            List<Point> pointList = new List<Point>() { new Point() };
            Point p1 = new Point();
            p1.X = 1;
            p1.Y = 1;
            list.Add(p1);
            Point p2 = new Point() { X = 1, Y = 1 };

            Fillist(list, 5);

            List<Point> program = new List<Point>();
            Point[] programList = new Point[5];

            foreach (int number in list) // для каждого элемента number в массиве list. Цикл за нас создает переменную number и прогоняет все значения list.
            // нюанс в том, что в переменную number ничего нельзя записать в ручную, как если бы мы создали переменную вручную. Переменная только на вывод.
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            // List имеет множество очень полезных методов
            int num = list.Find(x => x % 2 == 0); //  объявляем, что в list есть параметр x и дальше задаем тело функции, которая будет искать, что нам нужно. Выводит первое совпадение.
            // foreach (int x in list) // равносильно методу Find;
            // {
            //     if (x % 2 == 0)
            //     {
            //         num = x;
            //         break;
            //     }
            // }
            Console.WriteLine(num);

            List<int> evenNumList = list.FindAll(x => x % 2 == 0); // выводит все совпадения.
            foreach (int x in evenNumList)
            {
                Console.Write(x + "");
            }
        }

        /// <summary> Заполнение коллекции List<int> случайными числами от 0 до 10 </summary>
        /// <param name="list">List<int> для заполнения заначениями </param>
        /// <param name="count">List<int> количество случайных значений </param>
        public static void Fillist(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                //list[i] *= 2; // list [i] = list[i] * 2
                list.Add(new Random().Next(0, 11));
            }
        }

        public class Point // задаем новый класс.
        {
            public int X; // Переменные в классе называются ПОЛЯМИ и пишутся с большой буквы.
            public int Y;
        }
    }
}
