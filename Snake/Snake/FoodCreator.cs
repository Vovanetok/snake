﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random randon = new Random();

        public FoodCreator (int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        public Point CreateFood ()
        {
            int x = randon.Next(2, mapWidht - 2);
            int y = randon.Next(2, mapWidht - 2);
            return new Point(x, y, sym);
        }
    }
}
