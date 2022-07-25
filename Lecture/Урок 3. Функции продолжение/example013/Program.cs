// Методы бывают 4 видов.
// Первая группа, это которые ничего не принимают и ничего не возвращают.

// void Method1()
// {
//     Console.WriteLine("Автор ");
// }
// Method1();

// Вторая группа, это которые принимают какие-то аргументы, но ничего не возвращают.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 1;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
//     Console.WriteLine(msg);
// }
// // Method21("Текст сообщения", 4);
// Method21(count: 4, msg: "Текст сообщения");

// Третья группа, это методы, которые ничего не принимают на вход, но возвращают какие-то данные.

// int Method3()
// {
//     return DataTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Четвертая группа, это методы которые  и принимают и возвращают данные.
string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4 (10, "a");
Console.WriteLine(res);
