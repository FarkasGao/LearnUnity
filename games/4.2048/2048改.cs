using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2048
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCore core = new GameCore();
            core.ArrayRandom();
            core.ArrayRandom();
            DrawMap(core.Map);
            while (true)
            {
                KeyDown(core);
                Console.Clear();
                if (core.IsChange == true)
                {
                    core.ArrayRandom();
                    DrawMap(core.Map);
                }
            }
        }
        private static void DrawMap(int[,] map)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int t = 0; t < 4; t++)
                {
                    Console.Write(map[i, t] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void KeyDown(GameCore core)
        {
            switch (Console.ReadLine())
            {
                case "w": core.Move(MoveDirection.Up); break;
                case "s": core.Move(MoveDirection.Down); break;
                case "a": core.Move(MoveDirection.Left); break;
                case "d": core.Move(MoveDirection.Right); break;
            }
        }
    }
}










/*类中存放
 * 
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2048
{
    enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right,
    }
    /// <summary>
    /// 2048游戏核心算法,与界面无关
    /// </summary>
    class GameCore
    {
        private int[,] map;
        private int[] mergeArray;
        private int[] removeZeroArray;
        private Random mapLocation;
        private List<Location> emptyLocation;
        private int[,] originalMap;
        public bool IsChange { get; set; }
        public int[,] Map
        {
            get
            {
                return this.map;
            }
        }
        public GameCore()
        {
            map = new int[4, 4];
            mergeArray = new int[4];
            removeZeroArray = new int[4];
            mapLocation = new Random();
            emptyLocation = new List<Location>(16);
            originalMap = new int[4, 4];
        }
        private void CalculateEmpty()
        {
            emptyLocation.Clear();
            for (int r = 0; r< 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (map[r, c] == 0)
                    {
                        emptyLocation.Add(new Location(r, c));
                    }
                }
            }
        }
        public void ArrayRandom()
        {
            CalculateEmpty();
            if (emptyLocation.Count > 0)
            {
                int randomIndex = mapLocation.Next(0, emptyLocation.Count);
                Location location = emptyLocation[randomIndex];
                map[location.Rlndex, location.Clndex] = mapLocation.Next(0, 10) == 0 ? 4 : 2;
            }


        }
        private void RemoveZero()
        {
            Array.Clear(removeZeroArray, 0, 4);
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                if (mergeArray[i] != 0) removeZeroArray[index++] = mergeArray[i];
            }
            removeZeroArray.CopyTo(mergeArray, 0);
        }
        private void Merge()
        {
            RemoveZero();
            for (int i = 0; i < 3; i++)
            {
                if (mergeArray[i] != 0 && mergeArray[i] == mergeArray[i + 1])
                {
                    mergeArray[i] *= 2;
                    mergeArray[i + 1] = 0;
                }
            }
            RemoveZero();
        }
        private void MoveUp()
        {
            for (int c = 0; c < 4; c++)
            {
                for (int r = 0; r < 4; r++)
                {
                    mergeArray[r] = map[r, c];
                }
                Merge();
                for (int r = 0; r < 4; r++)
                {
                    map[r, c] = mergeArray[r];
                }
            }
        }
        private void MoveDown()
        {
            for (int c = 0; c < map.GetLength(0); c++)
            {
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    mergeArray[3 - r] = map[r, c];
                }
                Merge();
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    map[r, c] = mergeArray[3 - r];
                }
            }
        }
        private void MoveLeft()
        {
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = 0; c < map.GetLength(0); c++)
                {
                    mergeArray[c] = map[r, c];
                }
                Merge();
                for (int c = 0; c < map.GetLength(0); c++)
                {
                    map[r, c] = mergeArray[c];
                }
            }
        }
        private void MoveRight()
        {
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = map.GetLength(0) - 1; c >= 0; c--)
                {
                    mergeArray[3 - c] = map[r, c];
                }
                Merge();
                for (int c = map.GetLength(0) - 1; c >= 0; c--)
                {
                    map[r, c] = mergeArray[3 - c];
                }
            }
        }
        public void Move(MoveDirection direction)
        {
            Array.Copy(map, originalMap, originalMap.Length);
            switch (direction)
            {
                case MoveDirection.Up:
                    MoveUp(); break;
                case MoveDirection.Down:
                    MoveDown(); break;
                case MoveDirection.Left:
                    MoveLeft(); break;
                case MoveDirection.Right:
                    MoveRight(); break;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int t = 0; t < 4; t++)
                {
                    if (map[i, t] != originalMap[i, t])
                    {
                        IsChange = true;
                        return;
                    }
                }
            }
        }

    }

}

*/