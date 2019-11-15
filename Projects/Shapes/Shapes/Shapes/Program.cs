using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawShapes ds = new DrawShapes();
            ds.initiateConsole();
            ds.Triangle();

            for(int i = 0; i < 6; i++)
            {
                ds.leftTriangles();
                ds.rightTriangles();
            }
            Console.ReadLine();

        }
    }
}
