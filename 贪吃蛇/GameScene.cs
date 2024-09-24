using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class GameScene : ISceneUpdate
    {
        Map map;
        SnakeClass snake;
        Food food;
        int updateCount = 0;
        public GameScene()
        {

            map = new Map();
            snake  = new SnakeClass(4,5);
            food = new Food(snake);
        }

        public void Update()
        {
            

            if (updateCount % 7000 == 0) 
            {
             food.Draw();
             map.Draw();
             snake.Move();
             snake.Draw();
                if (snake.CheckEnd(map))
                {

                    Game.ChangeScene(E_SceneType.End);

                }
                snake.CheckEatFood(food);
             updateCount = 0;   
            }


            updateCount++; 

            // playerからのinputを検知
            if( Console.KeyAvailable) 
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeMoveDir(E_MoveDirection.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeMoveDir(E_MoveDirection.Left);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeMoveDir(E_MoveDirection.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeMoveDir(E_MoveDirection.Right);
                        break;
                }

            }








        }
    }
}
