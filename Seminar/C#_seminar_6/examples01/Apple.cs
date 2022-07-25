//using Bag2;
using Calc;

// namespace - специальные контейнеры, которые позволяют организовать код программы в логические блоки,
// поволяют объединить и отделить от остального кода некоторую функциональность, 
// которая связана некоторой общей идеей или которая выполняет определенную задачу.
namespace Bag1
{
    // internal - компоненты класса или структуры доступен из любого места кода в той же сборке,
    // однако он недоступен для других программ и сборок.
    internal class Program
    {
        static void Main()
        {
            Apple apple = new Apple();
            apple.weight = 100;
            apple.Name = "";
            // apple.Color = "green";
            // string s = apple.Name;
            apple.Count = 1;

            string s1 = apple.Name;
            Console.WriteLine(s1);

            apple.Name = "abcabc";
            Console.WriteLine(apple.Name);

            Math.Pow(2, 2);

            apple.Print(10, 100);

            Banana banana = new Banana();
            banana.weight = 200;
            banana.Name = "";
            // banana.Color = "green";
            banana.Count = 2;

            banana.Print();

            int sum = Calculation.Sum(5, 5, 5);
            Console.WriteLine("5 + 5 = " + sum);
        }
    }

    public class Person
    {
        public int pensia = 60;
        public int age;
        public string name;
    }

    // public - публичный, общедоступный компонент класса или структуры. 
    // Такой компонент доступен из любого места в коде, а также из других программ и сборок.
    public class Apple
    {
        public static int x = 1;
        // # region Поля_И_Свйойства
        // Вес яблока
        public int weight;
        // private - закрытый или приватный компонент класса или структуры. 
        // Приватный компонент доступен только в рамках своего класса или структуры.

        public string Name2 = "Apple";

        // Название яблока
        private string name = "Apple";
        public string Name
        {
            // get -- специальная функция, который вызывается при обращении к свойству (string s = apple.Name)
            get
            {
                return name;
            }
            // set -- специальная функция, которая вызывается, 
            // когда пытаемся запимать что-то в свойство (apple.Name = какое-то_значение)
            set
            {
                // string.IsNullOrEmpty(value) -- возвращает true, если value == null ИЛИ value == ""
                // ! -- меняем true на false и false на true
                // value -- кодовое слово, которое определяет входящее значение (apple.Name = какое-то_значение) -- value = какое-то_значение
                if (IsValid(value))
                {
                    name = value;
                }
            }

        }

        private bool IsValid(string name)
        {
            // какой-то код
            return true;
        }

        public string AppleInfo
        {
            get
            {
                return GetAppleInfo();
            }
        }

        // Количество яблок
        public int Count { get; set; }
        // цвет яблока
        private string color = "red";
        // # endregion

        // Функции класса
        public void Print(int x, int y)
        {
            Console.WriteLine(GetAppleInfo());
        }

        private string GetAppleInfo()
        {
            return $"Яблоко с названием {Name}, цветом {color}, весом {weight} и количеством {Count}";
        }
    }
}
