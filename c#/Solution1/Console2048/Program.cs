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
                    Console.Write(map[i,t] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void KeyDown(GameCore core)
        {
            switch(Console.ReadLine())
            {
                case "w": core.Move(MoveDirection.Up);break;
                case "s": core.Move(MoveDirection.Down);break;
                case "a": core.Move(MoveDirection.Left);break;
                case "d": core.Move(MoveDirection.Right);break;
            }
        }
    }
}
