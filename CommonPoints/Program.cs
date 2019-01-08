using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Input();

            for (int i = 0; i < Parser.NumberOfRectangles;i++ )
            {
                if (Parser.rectangle[i].CheckRectangle())
                {
                    break;
                }
            }
            Console.ReadLine();
        }
        
    }
}
