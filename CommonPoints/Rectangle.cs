using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPoints
{
    class Rectangle
    {
        public int NumberOfPoints;
        public Point[] point;
        public Rectangle(int idRectangle,int xl, int yl, int xh, int yh)
        {
            int sizeX = (xh - xl) + 1;
            int sizeY = (yh - yl) + 1;
            NumberOfPoints = sizeX * sizeY;
            int k = 0;
            point = new Point[NumberOfPoints];
            for (int j = 0; j < sizeY; j++)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    point[k] = new Point(idRectangle, i + xl, j + yl); // создаем точки для каждого квадрата
                    k++;
                }
            }
        }
        public bool CheckRectangle()
        {
            for (int i = 0; i < NumberOfPoints; i++)
            {
                if (point[i].CheckIsCommonAndCheckFinishTask())
                {
                    Console.WriteLine("X={0} Y={1}", point[i].x, point[i].y);
                    return true;
                }
            }
            return false;
        }
    }
}
