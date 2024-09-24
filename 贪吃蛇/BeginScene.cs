using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class BeginScene : BeginOrEndBase
    {
        public BeginScene() {

            strTitle = "ただの蛇ゲーム";
            strOne = "Game Start";
            strTwo = "(use J to confirm)";
        
        
        }


        public override void EnterJ()
        {
            if(nowSelectIndex == 0)
            {


                Game.ChangeScene(E_SceneType.Game);

            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
