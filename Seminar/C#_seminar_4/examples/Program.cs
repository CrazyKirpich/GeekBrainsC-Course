// namespace - специальные контейнеры, которые позволяют организовать код программы в логические блоки,
// позволяют объединить и отделить от остального кода некоторую функциональность, 
// которая связана некоторой общей идеей или которая выполняет определенную задачу.
namespace Bag1
{
    // internal - компонент класса или структуры, доступен из любого места кода в той же сборке, однако недоступен для другий программ и сборок.
    internal class Program
    {
        public static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.weight = 100;
            apple.Name = "";
            // apple.Color = "green";
            //string s = apple.Name;
            apple.Count = 1;

            string s1 = apple.Name;
            Console.WriteLine(s1);

            apple.Name = "abcabc";
            Console.WriteLine(apple.Name);

            apple.Print();
        }
    }
    // public - публичный, общедоступный компонент класса  или структуры.
    // Такой компонент доступен из любого места в коде, а также из других программ и сборок.
    public class Apple
    {
        #region Поля_И_Свойства
        public int weight = 5; // вот это просто поле.
        public string Name2 = "Apple";
        private string name = "Apple"; // private - закрытый или приватный компонент класса  или структуры. Приватный компонент доступен только в рамках своего класса или структуры.
        public string Name // а вот это свойство. у свойства васегда есть методы get и set. Свойство - это переменная. 
        {
            get // get - специальная функция, которая вызывается при обращении к свойству  (string s = apple.Name). get - отрабатывает при получении данных.
            {
                return name;
            }
            set // специальная функция, которая вызывается, когда пытаемся записать что-то в свойства (apple.Name = какое-то значение). get - отрабатывает при записи новых данных.
            {
                // string.IsNullOrEmpty(value) - возвращает true, если value == nul или value == ""
                // ! -- меняет true на false и false на true
                // value - кодовое слово, которое определяет входящее значение (apple.Name = какое-то_значение) -- value = какое-то_значение)
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public int Count { get; set; }
        private string Color = "red";
        # endregion
        public void Print()
        {
            Console.WriteLine(GetAppleInfo());
        }
        private string GetAppleInfo()
        {
            return $"Яблоко с названием {Name}, цветом {Color}, весом {weight} и количеством {Count}";
        }
    }
}


