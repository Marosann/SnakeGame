using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food : GameObject
    {

        public Food(SnakeClass snake)
        {

            RandomPos(snake);

            
        }


        public override void Draw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write("◆");
        }

        public void RandomPos(SnakeClass snake)
        {
             
            Random random = new Random();
            int x = random.Next(2,Game.w/2-7)*2;
            int y = random.Next(1,Game.h - 3);
            position  = new Position(x, y);


            if(snake.CheckSamePos(position))
            {
                RandomPos(snake);
                
            }



        }



    }
}
