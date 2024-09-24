﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal struct Position
    {
        public int x; public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public static bool operator ==(Position left, Position right)
        {
            if (left.x == right.x &&left.y == right.y)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }        
        public static bool operator !=(Position left, Position right)
        {
            if(left != right)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

    }
}
