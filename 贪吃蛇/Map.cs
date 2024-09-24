using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Map : IDraw
    {

        public Wall[] walls;
        
        public Map()
        {
            //横の壁
            walls = new Wall[Game.w+(Game.h - 3)*2];
            int index = 0;
            for (int i = 0; i < Game.w; i+=2)
            {
                walls[index] = new Wall(i,0);
                ++index;
            }            
            for (int i = 0; i < Game.w; i+=2)
            {
                walls[index] = new Wall(i,Game.h-2);
                ++index;
            }
            //縦の壁
            for (int i = 1; i < Game.h - 2; i++)
            {
                walls[index] = new Wall(0, i);
                ++index;
            }
            for (int i = 1; i < Game.h - 2; i++)
            {
                walls[index] = new Wall(Game.w-2, i);
                ++index;
            }
        }

        public void Draw()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].Draw(); 
            }
        }


    }
}
