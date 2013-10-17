using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    //Some code for other Ríkharður : Math.sqrt(Math.pow((float)(Enemy.position.x-Player.position.x), 2) + Math.pow((float)(Enemy.position.y-Player.position.y), 2))

    public class Client
    {
        public static const Client GAME = new Client();

        public static void Main()
        {
            //Game loop
            while (true)
            {
                GAME.update();
                GAME.render();
            }
        }

        public void update()
        {

        }

        public void render()
        {

        }
    }

    class Item
    {
        public Item()
        {

        }

        //Placeholder method
        public bool isShield()
        {
            return false;
        }
    }
}
