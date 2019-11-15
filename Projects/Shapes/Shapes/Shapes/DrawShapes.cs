using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class DrawShapes
    {
        int xPos = 50;
        int yPos = 0;

        int oldxPos = 50;
        int oldyPos = 0;
        int counter = 0;

        public void initiateConsole()
        {
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
        }

        public void resetPos()
        {
            xPos = oldxPos;
            yPos = oldyPos;
        }

        public void Triangle()
        {

            Console.SetCursorPosition(xPos, yPos);
            Console.Write("*");
            xPos = xPos - 1;
            yPos = yPos + 1;
            Console.SetCursorPosition(xPos, yPos);
            Console.Write("*");
            xPos = xPos + 2;
            Console.SetCursorPosition(xPos, yPos);
            Console.Write("*");

        }

        public void leftTriangles()
        {
            yPos = yPos + 1;
            xPos = xPos + -3;
            Console.SetCursorPosition(xPos, yPos);
            Triangle();
            counter++;
        }

        public void rightTriangles()
        {
            yPos = yPos - 1;
            xPos = xPos + 3;
            Console.SetCursorPosition(xPos, yPos);
            Triangle();
            counter++;

        }

    }
}
