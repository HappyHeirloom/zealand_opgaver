using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpinski
{
        class Program
        {
            static void DotPrint(int x, int y, ConsoleColor col)
            {
                Console.ForegroundColor = col;
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(".");
            }
            static void Main(string[] args)
            {
                Console.CursorVisible = false;
                Console.SetWindowSize(80, 40);
                int times = 0;
                Random rnd = new Random();
                Console.WriteLine();
                Console.Write("Enter Number of Times:");
                times = int.Parse(Console.ReadLine());
                int ChangeX = 35;
                int ChangeY = 20;
                int random = 0;
                for (int i = 0; i < times; i++)
                {
                    random = rnd.Next(0, 3);
                    switch (random)
                    {
                        case 0: //red dot
                            ChangeX = (ChangeX + 35) / 2; // the 35 is the x value of the red dot
                            ChangeY = (ChangeY + 1) / 2;
                            DotPrint(ChangeX, ChangeY, ConsoleColor.Red);
                            break;
                        case 1: // blue dot
                            ChangeX = (ChangeX + 1) / 2;
                            ChangeY = (ChangeY + 35) / 2;
                            DotPrint(ChangeX, ChangeY, ConsoleColor.Blue);
                            break;
                        case 2: // green dot
                            ChangeX = (ChangeX + 70) / 2;
                            ChangeY = (ChangeY + 35) / 2;
                            DotPrint(ChangeX, ChangeY, ConsoleColor.Green);
                            break;
                    }
                }
                Console.ReadKey();
            }
        }
    }
