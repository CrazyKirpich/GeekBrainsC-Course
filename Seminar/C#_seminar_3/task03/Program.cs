// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25.
// namespace HelloWorld
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Введите число:");
//             int a = Convert.ToInt32(Console.ReadLine());
//             for (int i = 1; i <= a; i++)
//             {
//                 PrintSquare(i);
//             }
//         }    
//         public static void PrintSquare(int n)
//         {        
//             Console.WriteLine(n * n);
//         }
//     }
// }


 namespace HelloWorld
 {
     class Program
     {
         public static void Main(string[] args)
         {
             Console.WriteLine("Введите число:");
             int a = Convert.ToInt32(Console.ReadLine());            
             for (int i = 1; i <= a; i++)
             {
                 PrintSquare(i);
             }
         }    
         public static void PrintSquare(int n)
         {        
             Console.WriteLine(n * n);
         }
     }
 }