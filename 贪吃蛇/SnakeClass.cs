using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

/// <summary>
/// 蛇の移動方向
/// </summary>
    enum E_MoveDirection
    {  /// <summary>
       /// 上
       /// </summary>
        Up, 
        /// <summary>
        /// 下向け
        /// </summary>
        Down,
        /// <summary>
        /// 左向け
        /// </summary>
        Left, 
        /// <summary>
        /// 右向け
        /// </summary>
        Right
    }



    internal class SnakeClass : IDraw
    {
        public SnakeBody[] bodys;
        
        //蛇の長さを記録
        int nowNum;
        // 今の移動方向
        E_MoveDirection moveDirection;

        public SnakeClass(int x,int y)
        {
            // 基本蛇の長さは200以上にならないため  
            bodys = new SnakeBody[200];
            bodys[0] = new SnakeBody(x, y, E_SnakeBody_Type.Head);
            ++nowNum;
            
            moveDirection = E_MoveDirection.Right;
        }

        public E_MoveDirection GetMoveDirection()
        {
            return moveDirection;
        }


        #region SnakeMove

        public void Move()
        {
            //移動する前に、お尻を消す

            SnakeBody lastBody = bodys[nowNum - 1];
            Console.SetCursorPosition(lastBody.position.x, lastBody.position.y);
            Console.WriteLine("  ");


            // 頭が移動する前に、尻から継続的に、後ろの体の位置を前の体の位置に変更
            for (int i = nowNum-1; i > 0; i--)
            {
                bodys[i].position = bodys[i-1].position; 
            }
         


            switch (moveDirection)
            {
                case E_MoveDirection.Up:
                    --bodys[0].position.y;
                    break;
                case E_MoveDirection.Down:
                    ++bodys[0].position.y;
                    
                    break;
                case E_MoveDirection.Left:
                    bodys[0].position.x -=2;
                    break;
                case E_MoveDirection.Right:
                    bodys[0].position.x +=2;
                    break;
                
            }
        }

        #endregion

        #region ChangeMoveDir
        public void ChangeMoveDir(E_MoveDirection moveDir)
        {

            if(moveDir == moveDirection || 
                nowNum >1 &&
                (moveDirection == E_MoveDirection.Left && moveDir == E_MoveDirection.Right ||
                moveDirection == E_MoveDirection.Right && moveDir == E_MoveDirection.Left||
                moveDirection == E_MoveDirection.Up && moveDir == E_MoveDirection.Down||
                moveDirection == E_MoveDirection.Down  && moveDir == E_MoveDirection.Up ))
            {
                return;
            }

            moveDirection = moveDir;



        }

        #endregion


        #region HitTheWall

        public bool CheckEnd(Map map)
        {
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].position == map.walls[i].position)
                {
                    return true;
                }
                
                
            }

            for (int i = 1; i < nowNum; i++)
            {
                if (bodys[0].position == bodys[i].position)
                {
                    return true;
                }
            }


             return false; 

        }
        #endregion

        
        public bool CheckSamePos(Position p) 
        {


            for (int i = 0; i < nowNum; i++)
            {
                if (bodys[i].position == p)
                {
                    return true;
                }

            }


            return false;
        }    

        public void CheckEatFood(Food f)
        {
            if (bodys[0].position==f.position)
            {
                f.RandomPos(this);
                GrowUp();
            }

           
        }

        private void GrowUp()
        {

            SnakeBody frontBody = bodys[nowNum-1];

            bodys[nowNum] = new SnakeBody(frontBody.position.x,frontBody.position.y, E_SnakeBody_Type.Body);


            nowNum++;
            
           

        }


        public void Draw()
        {

            for (int i = 0; i < nowNum; i++)
            {
                bodys[i].Draw();
            }

        }
    }
}
