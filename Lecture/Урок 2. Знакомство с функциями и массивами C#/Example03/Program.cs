﻿// Найти нужный элемент в массиве
int [] array = {1, 12, 31, 4, 18, 16, 17, 18};
int n = array.Length;
int find = 18;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // Заканчивает цикл при первом совпадении с требованиями
    }
    index++; // index = index + 1
}
