using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY11
{
    static class DoubleArrayHelper
    {
        /// <summary>
        /// 获取二维数组元素
        /// </summary>
        /// <param name="array">二维数组</param>
        /// <param name="rindex">行索引</param>
        /// <param name="clndex">列索引</param>
        /// <param name="dir">方向</param>
        /// <param name="count">希望获取数量</param>
        /// <returns>所有满足条件的元素</returns>
        public static int[] GetElements(int[,] array,int rlndex,int clndex,Direction dir,int count)
        {
            List<int> result = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                rlndex += dir.Rlndex;
                clndex += dir.Clndex;
                if (rlndex >= 0 && clndex >= 0&&rlndex<array.GetLength(0)&&clndex<array.GetLength(1))
                    result.Add(array[rlndex, clndex]);
            }
            return result.ToArray();
        }
    }
    struct Direction
    {
        public int Rlndex { get; set; }
        public int Clndex { get; set; }
        public Direction(int rlndex,int clndex)
        {
            this.Rlndex = rlndex;
            this.Clndex = clndex;
        }
        public static Direction Up
        {
            get
            {
                return new Direction(-1, 0);
            }
        }
        public static Direction Down
        {
            get
            {
                return new Direction(1, 0);
            }
        }
        public static Direction Left
        {
            get
            {
                return new Direction(0, -1);
            }
        }
        public static Direction Right
        {
            get
            {
                return new Direction(0, -1);
            }
        }

    }
}
