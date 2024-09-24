using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{


    enum E_SceneType
    {
        Begin,
        Game,
        End,


    }






    internal class Game
    {   
        //windowの長さと幅
        public const int w = 80;
        public const int h = 20;
        //今いるシーン
        public static ISceneUpdate nowScene;

        public Game() 
        {
            Console.CursorVisible= false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            ChangeScene(E_SceneType.Begin);
        
        
        
        
        
        }



        public void GameStart()
        {

            while (true)
            {
                if (nowScene != null)
                {
                    nowScene.Update();
                    
                }            
            }


        }

        public static void ChangeScene(E_SceneType type)
        {
            Console.Clear();
             

            switch (type)
            {
                case E_SceneType.Begin:
                    nowScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    nowScene  = new GameScene();
                    break;
                case E_SceneType.End:
                   nowScene = new EndScene();
                    break;
            }




        }




    }

}
