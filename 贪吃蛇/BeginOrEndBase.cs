using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Snake

{
    internal abstract class BeginOrEndBase:ISceneUpdate
    {
        protected int nowSelectIndex = 0;
        protected string strTitle;
        protected string strOne;
        protected string strTwo;

        public abstract void EnterJ();

        public void Update()
        {
            //タイトルを表示
            Console.ForegroundColor= ConsoleColor.White;
            Console.SetCursorPosition(Game.w/2-strTitle.Length, 5);
            Console.WriteLine(strTitle);
            Console.SetCursorPosition(Game.w / 2 - strTwo.Length/2, 7);
            Console.WriteLine(strTwo);
            //選択肢を表示
            Console.SetCursorPosition(Game.w/2-strOne.Length/2, 9);
            Console.ForegroundColor = nowSelectIndex==0?ConsoleColor.Red:ConsoleColor.White;
            Console.WriteLine(strOne);            
            
            Console.SetCursorPosition(Game.w/2-2, 12);
            Console.ForegroundColor = nowSelectIndex==1?ConsoleColor.Red:ConsoleColor.White;
            Console.WriteLine("Exit");

            //input検出

            switch(Console.ReadKey(true).Key) 
            {

                case ConsoleKey.W:
                    --nowSelectIndex;
                    if (nowSelectIndex < 0)
                    {
                        nowSelectIndex = 0;
                    }
                    break;

                    case ConsoleKey.S:
                    ++nowSelectIndex;
                    if (nowSelectIndex > 1)
                    {
                        nowSelectIndex = 1;
                    }
                    break;

                    case ConsoleKey.J:
                    EnterJ();
                    break;
                                      
                    






            }

        }


    }
}
