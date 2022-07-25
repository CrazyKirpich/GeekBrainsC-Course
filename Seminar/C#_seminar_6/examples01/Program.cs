// Различные способы перевода строки в число.
// Вариант 1 через try, catch.
namespace GB
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число");
                string? str = Console.ReadLine();
                int num = Convert.ToInt32(str);
                num = num / 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неправильные данные");
                Main(new string[] { "" });
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя!"); // в зависимости от введенных данных срабатывает разный catch. (введем "asd", а потом "123")
            }
            finally
            {
                Console.WriteLine("Finally"); 
            }
        }
    }
}
