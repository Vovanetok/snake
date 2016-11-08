﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(1, 23, 0, '+');
            VerticalLine rightLine = new VerticalLine(1, 23, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            Console.ReadLine();
        }

    }
}
