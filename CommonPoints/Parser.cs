using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonPoints
{
    class Parser
    {
        static public int NumberOfRectangles;
        static public Rectangle[] rectangle;
        public static void Input()
        {
            string path = @"Test.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = sr.ReadLine();
                if (Int32.TryParse(line, out NumberOfRectangles))
                {

                    if (NumberOfRectangles < 2 || NumberOfRectangles > 132) Console.WriteLine("Некорректный ввод. Число прямоугольников равно от 2 до 132"); // проверка ввода количества прямоугольников
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Число прямоугольников является целым числом ");
                }
                rectangle = new Rectangle[NumberOfRectangles]; //
                for (int i = 0; i < NumberOfRectangles; i++)
                {

                    line = sr.ReadLine();

                    string[] data = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int xl = int.Parse(data[0]);
                    int yl = int.Parse(data[1]);
                    int xh = int.Parse(data[2]);
                    if (xh < xl)
                    {
                        Console.WriteLine("3-ая координата в прямоугольнике {0} должна быть больше чем первая  ", i);
                    }
                    int yh = int.Parse(data[3]);
                    if (yh < yl)
                    {
                        Console.WriteLine("4-ая координата в прямоугольнике {0} должна быть больше чем вторая ", i);
                    }
                    rectangle[i] = new Rectangle(i, xl, yl, xh, yh); // создание квадратов
                }
            } 
        }
    }
}
