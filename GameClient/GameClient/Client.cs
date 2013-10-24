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
        public static Client GAME = new Client();

        public void loop()
        {
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

    public class Test
    {
        public static void test()
        {
            Creature cre1 = new NPC("Peasant", 10, 11, 8, 10);
            Creature cre2 = new NPC("Drunkard", 12, 9, 6, 11);
            Combat combat = new Combat(new Creature[] { cre1 }, new Creature[] { cre2 }, false);
        }
    }

    class Message
    {
        public static void sendMessagePlayer(string str)
        {
            Console.Out.WriteLine(str);
        }

        public static void sendMessageDev(string str)
        {
            Console.Out.WriteLine(str);
        }
    }

    class Item
    {
        private Dictionary<string, int> itemAttributes = null;

        public Item()
        {

        }

        //Needs to be implemented
        public string getItemType()
        {
            return null;
        }

        public int getItemAttribute(string attribute)
        {
            return itemAttributes[attribute];
        }

        //Placeholder method
        public bool isShield()
        {
            return false;
        }
    }
}
