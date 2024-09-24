using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum E_SnakeBody_Type
    {   
        /// <summary>
        /// 頭
        /// </summary>
        Head,
        /// <summary>
        /// 体
        /// </summary>
        Body,

    }

    internal class SnakeBody : GameObject
    {
        private E_SnakeBody_Type type;

        public SnakeBody(int x, int y,E_SnakeBody_Type type)
        {
            this.type = type;
            position = new Position(x,y);


        }

        public override void Draw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor= type == E_SnakeBody_Type.Head?ConsoleColor.Yellow:ConsoleColor.Green;
            Console.Write(type == E_SnakeBody_Type.Head ? "●" : "◎");
        }


    }
}
