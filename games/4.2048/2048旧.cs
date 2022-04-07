using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5      //未完善，1.游戏结束的判定未作 2.没有空生成随机数时，游戏会卡死。
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "2048";
            int[,] array = new int[4, 4];
            array = ArrayRandom(array);
            do
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        Console.Write(array[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                int i = 1;
                string input = Console.ReadLine();

                if (input == "a") array = MoveLeft(array);
                else if (input == "d") array = MoveRight(array);
                else if (input == "w") array = MoveUp(array);
                else if (input == "s") array = MoveDown(array);
                else
                {
                    Console.WriteLine("Please input w,s,a,d to control");
                    i = 0;
                }
                if (i != 0) array = ArrayRandom(array);

            } while (true);
        }
        private static int[,] ArrayRandom(int[,] array)
        {
            Random location = new Random();
            for (int i = 0; i < 2;)
            {

                int x = location.Next(0, 4);
                int y = location.Next(0, 4);
                if (array[y, x] == 0)
                {
                    array[y, x] = 2;
                    i++;
                }

            }
            return array;
        }
        private static int[] RemoveZero(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0) newArray[index++] = array[i];
            }
            return newArray;
        }
        private static int[] Merge(int[] array)
        {
            array = RemoveZero(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != 0 && array[i] == array[i + 1])
                {
                    array[i] *= 2;
                    array[i + 1] = 0;
                }
            }
            array = RemoveZero(array);
            return array;
        }
        private static int[,] MoveUp(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(0)];
            for (int c = 0; c < map.GetLength(0); c++)
            {
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    mergeArray[r] = map[r, c];
                }
                mergeArray = Merge(mergeArray);
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    map[r, c] = mergeArray[r];
                }
            }
            return map;
        }
        private static int[,] MoveDown(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(0)];
            for (int c = 0; c < map.GetLength(0); c++)
            {
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    mergeArray[3 - r] = map[r, c];
                }
                mergeArray = Merge(mergeArray);
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    map[r, c] = mergeArray[3 - r];
                }
            }
            return map;
        }
        private static int[,] MoveLeft(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(1)];
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = 0; c < map.GetLength(0); c++)
                {
                    mergeArray[c] = map[r, c];
                }
                mergeArray = Merge(mergeArray);
                for (int c = 0; c < map.GetLength(0); c++)
                {
                    map[r, c] = mergeArray[c];
                }
            }
            return map;
        }
        private static int[,] MoveRight(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(1)];
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = map.GetLength(0) - 1; c >= 0; c--)
                {
                    mergeArray[3 - c] = map[r, c];
                }
                mergeArray = Merge(mergeArray);
                for (int c = map.GetLength(0) - 1; c >= 0; c--)
                {
                    map[r, c] = mergeArray[3 - c];
                }
            }
            return map;
        }
    }
}
