using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPoints
{
    class Point
    {
        public List<Point> SamePoints = new List<Point>(); // коллекция точек с такими же координатами, только в других квадратах
        public int IdRectangle; // уникальный номер "имя" квадрата для точки
        public int x, y;
        public Point(int id,int x, int y)
        {
            IdRectangle = id;
            this.x = x;
            this.y = y;
        }
        public bool CheckIsCommonAndCheckFinishTask()
        {
            for (int i = 0; i < Parser.NumberOfRectangles; i++)
            {
                for (int j = 0; j < Parser.rectangle[i].NumberOfPoints; j++)
                {
                    if ((x == Parser.rectangle[i].point[j].x) && (y == Parser.rectangle[i].point[j].y) && (IdRectangle != Parser.rectangle[i].point[j].IdRectangle)) // проверка на X,Y но в других квадратах
                    {
                        if (!SamePoints.Contains(Parser.rectangle[i].point[j])) // в коллекцию не добавляются уже существующие там, даже если соответствуют условию
                         {
                             SamePoints.Add(Parser.rectangle[i].point[j]); 
                         }
                        if (SamePoints.Count()==(Parser.NumberOfRectangles-2))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
