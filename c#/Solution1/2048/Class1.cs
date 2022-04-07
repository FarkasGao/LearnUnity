using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    enum PersonStyle
    {
        tall,
        rich,
        handsome,
        white,
        beauty,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "2048";
            int[,] array = new int[4, 4];
            ArrayRandom(array);
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

                if (input == "a") MoveLeft(array);
                else if (input == "d") MoveRight(array);
                else if (input == "w") MoveUp(array);
                else if (input == "s") MoveDown(array);
                else
                {
                    Console.WriteLine("Please input w,s,a,d to control");
                    i = 0;
                }
                if (i != 0) ArrayRandom(array);

            } while (true);
        }
        private static void ArrayRandom(int[,] array)
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
        }
        private static void RemoveZero(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0) newArray[index++] = array[i];
            }
            newArray.CopyTo(array, 0);
        }
        private static void Merge(int[] array)
        {
            RemoveZero(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != 0 && array[i] == array[i + 1])
                {
                    array[i] *= 2;
                    array[i + 1] = 0;
                }
            }
            RemoveZero(array);
        }
        private static void MoveUp(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(0)];
            for (int c = 0; c < map.GetLength(0); c++)
            {
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    mergeArray[r] = map[r, c];
                }
                Merge(mergeArray);
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    map[r, c] = mergeArray[r];
                }
            }
        }
        private static void MoveDown(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(0)];
            for (int c = 0; c < map.GetLength(0); c++)
            {
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    mergeArray[3 - r] = map[r, c];
                }
                Merge(mergeArray);
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    map[r, c] = mergeArray[3 - r];
                }
            }
        }
        private static void MoveLeft(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(1)];
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = 0; c < map.GetLength(0); c++)
                {
                    mergeArray[c] = map[r, c];
                }
                Merge(mergeArray);
                for (int c = 0; c < map.GetLength(0); c++)
                {
                    map[r, c] = mergeArray[c];
                }
            }
        }
        private static void MoveRight(int[,] map)
        {
            int[] mergeArray = new int[map.GetLength(1)];
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = map.GetLength(0) - 1; c >= 0; c--)
                {
                    mergeArray[3 - c] = map[r, c];
                }
                Merge(mergeArray);
                for (int c = map.GetLength(0) - 1; c >= 0; c--)
                {
                    map[r, c] = mergeArray[3 - c];
                }
            }
        }
        private static void Move(int[,] map,MoveDirection direction)
        { 
            switch(direction)
            {
                case MoveDirection.Up: 
                    MoveUp(map); break;
                case MoveDirection.Down:
                    MoveDown(map);break;
                case MoveDirection.Left:
                    MoveLeft(map);break;
                case MoveDirection.Right:
                    MoveRight(map);break;
            }
        }
    }
}
