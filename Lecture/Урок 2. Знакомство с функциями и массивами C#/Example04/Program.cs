void FillArray(int[] collection)  // void - метод, который ничего не возвращает. Нельзя использовать с return
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection[index] = new Random().Next(1, 10); 
       index++; 
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // эта конструкция создает новый массив, заполненный 0(НУЛЯМИ)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);