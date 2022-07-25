// Задача 1. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

namespace Seminar9
{
    class Task1
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int[,] newArray = new int[new Random().Next(4, 6), new Random().Next(4, 6)];
            int[,] randomArray = FillRandomArray(newArray);
            PrintArray(randomArray);
            Console.WriteLine();
            int[] minPositionIndexes = FindMinRowAndColumnPosition(randomArray);
            // int minRowPosition = 0;
            // int minColumnPosition = 0;
            // FindMinRowAndColumnPosition(randomArray
            //                             ,minRowPosition,
            //                             minColumnPosition,
            //                             out minRowPosition,
            //                             out minColumnPosition);
            int[,] smallArray = new int[randomArray.GetLength(0) - 1, randomArray.GetLength(1) - 1];
            int[,] changedArray = RemoveRowAndColumnWithMinElement(randomArray
                                                                   , smallArray
                                                                   , minPositionIndexes
                                                                   //    ,minRowPosition
                                                                   //    ,minColumnPosition
                                                                   );
            PrintArray(changedArray);
        }

        public static int[,] FillRandomArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }
            return array;
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[] FindMinRowAndColumnPosition(int[,] randomArray
                                                    //    ,int minRowPosition
                                                    //    ,int minColumnPosition
                                                    //    ,out int outData1
                                                    //    ,out int outData2
                                                    )
        {
            int[] minPositionIndexes = new int[] { 0, 0 };
            int minElement = randomArray[0, 0];
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    if (randomArray[i, j] < minElement)
                    {
                        minElement = randomArray[i, j];
                        minPositionIndexes[0] = i;
                        minPositionIndexes[1] = j;
                    }
                }
            }
            return minPositionIndexes;
            // int minRowPos = 0;
            // int minColumnPos = 0;
            // int minElement = randomArray[0, 0];
            // for (int i = 0; i < randomArray.GetLength(0); i++)
            // {
            //     for (int j = 0; j < randomArray.GetLength(1); j++)
            //     {
            //         if (randomArray[i, j] < minElement)
            //         {
            //             minElement = randomArray[i, j];
            //             minRowPos = i;
            //             minColumnPos = j;
            //         }
            //     }
            // }
            // outData1 = minRowPos;
            // outData2 = minColumnPos;
        }

        public static int[,] RemoveRowAndColumnWithMinElement(int[,] randomArray
                                                              , int[,] smallArray
                                                              , int[] minPositionIndexes
                                                              //,int minRowPosition
                                                              //,int minColumnPosition
                                                              )
        {
            int x = 0;
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                if (i != minPositionIndexes[0]) // minRowPosition
                {
                    int y = 0;
                    for (int j = 0; j < randomArray.GetLength(1); j++)
                    {
                        if (j != minPositionIndexes[1]) // minColumnPosition
                        {
                            smallArray[i - x, j - y] = randomArray[i, j];
                        }
                        else
                        {
                            y = 1;
                        }
                    }
                }
                else
                {
                    x = 1;
                }
            }
            return smallArray;
        }
    }
}
