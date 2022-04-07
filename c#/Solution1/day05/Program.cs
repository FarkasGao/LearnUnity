using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    class Program
    {
        static void Main(string[] args)
        {
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

                if (input == "a") array = InputA(array);
                else if (input == "d") array = InputD(array);
                else if (input == "w") array = InputW(array);
                else if (input == "s") array = InputS(array);
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
        private static int[,] InputW(int[,] array)
        {
            for (int t = 0; t < 4; t++)
            {
                int symbol = -1;//
                for (int i = 0; i < 4; i++)
                {
                    if (array[i, t] != 0)
                    {
                        for (int y = 0; y < i; y++)
                        {
                            if (array[y, t] == 0)//数的上方没有数
                            {
                                array[y, t] = array[i, t];
                                array[i, t] = 0;
                            }
                            else
                            {
                                if (array[y, t] == array[i, t])
                                {
                                    if (i - y != 1)
                                    {
                                        if (array[y +1, t] != 0) continue;
                                        if (array[i - 1, t] != 0) continue;
                                    }
                                    if (y == symbol) continue;
                                    array[y, t] = array[y, t] * 2;
                                    array[i, t] = 0;
                                    symbol = y;
                                }

                            }
                        }
                    }
                }
            }
            return array;
        }
        private static int[,] InputS(int[,] array)
        {
            for (int t = 0; t < 4; t++)
            {
                int symbol = -1;//
                for (int i = 3; i >= 0; i--)
                {
                    if (array[i, t] != 0)
                    {
                        for (int y = 3; y > i; y--)
                        {
                            if (array[y, t] == 0)
                            {
                                array[y, t] = array[i, t];
                                array[i, t] = 0;
                            }
                            else
                            {
                                if (array[y, t] == array[i, t])
                                {
                                    if (y-i != 1)
                                    {
                                        if (array[ y -1 , t] != 0) continue;
                                        if (array[ i + 1, t ] != 0) continue;
                                    }
                                    if (y == symbol) continue;
                                    array[y, t] = array[y, t] * 2;
                                    array[i, t] = 0;
                                    symbol = y;
                                }

                            }
                        }
                    }
                }
            }
            return array;
        }
        private static int[,] InputA(int[,] array)
        {
            for (int i = 0; i < 4; i++)
            {
                int symbol = -1;//
                for (int t = 0; t < 4; t++)
                {
                    
                    if (array[i, t] != 0)
                    {
                        for (int x = 0; x < t; x++)
                        {
                            if (array[i, x] == 0)
                            {
                                array[i, x] = array[i, t];
                                array[i, t] = 0;
                            }
                            else
                            {
                                if (array[i, x] == array[i, t])
                                {
                                    if(t-x!=1)
                                    {
                                        if (array[i, x + 1] != 0) continue;
                                        if (array[i, t - 1] != 0) continue;
                                    }
                                    if (x==symbol) continue;//
                                    array[i, x] = array[i, x] * 2;
                                    array[i, t] = 0;
                                    symbol = x;//
                                }

                            }
                        }
                    }
                }
            }
            return array;
        }
        private static int[,] InputD(int[,] array)
        {
            for (int i = 0; i < 4; i++)
            {
                int symbol = -1;
                for (int t = 3; t >= 0; t--)
                {
                    if (array[i, t] != 0)
                    {
                        for (int x = 3; x > t; x--)
                        {
                            if (array[i, x] == 0)
                            {
                                array[i, x] = array[i, t];
                                array[i, t] = 0;
                            }
                            else
                            {
                                if (array[i, x] == array[i, t])
                                {
                                    if (x-t != 1)
                                    {
                                        if (array[i, x - 1] != 0) continue;
                                        if (array[i, t + 1] != 0) continue;
                                    }
                                    if (x == symbol) continue;
                                    array[i, x] = array[i, x] * 2;
                                    array[i, t] = 0;
                                    symbol = x;
                                }

                            }
                        }
                    }
                }
            }
            return array;
        }
    }
}
