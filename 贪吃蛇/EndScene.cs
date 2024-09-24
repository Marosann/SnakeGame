using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class EndScene : BeginOrEndBase
    {
        public EndScene() 
        {
            strTitle = "ゲーム終了だよ";
            strOne = "Main menu";
            strTwo = " ";
        
        
        
        
        
        }



        public override void EnterJ()
        {
           
            if(nowSelectIndex == 0)
            {

                Game.ChangeScene(E_SceneType.Begin);



            }
            else
            {
                Environment.Exit(0);
            }


        }
    }
}
