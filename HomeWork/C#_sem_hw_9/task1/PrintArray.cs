namespace MyPrint
{
    class PrintArrays
    {
        public static void PrintArray(int[] sequenceArray)
        {
            for (int i = 0; i < sequenceArray.GetLength(0); i++)
            {
                Console.Write($"{sequenceArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}