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
        public void loop()
        {
            while (true)
            {
                ConstantLib.GAME.update();
                ConstantLib.GAME.render();
            }
        }

        public void update()
        {

        }

        public void render()
        {

        }
    }

    class ConstantLib
    {
        public static Client GAME = new Client();
        public static Random RANDOM = new Random();
    }

    public class Test
    {
        public static void test()
        {
            Creature cre1 = new NPC("Peasant", 10, 12, 9, 5);
            Creature cre2 = new NPC("Drunkard", 12, 9, 8, 6);
            Combat combat = new Combat(new Creature[] { cre1 }, new Creature[] { cre2 }, false);
            Console.ReadLine();
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
        protected Dictionary<string, int> itemAttributes = null;
        protected string equipSlot;

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

    class ItemShield : Item
    {
        public ItemShield() : base()
        {

        }

        public int getBlock()
        {
            return 0;
        }
    }

    class ItemWeapon : Item
    {
        private List<string> damageTypes = new List<string>();

        public ItemWeapon() : base()
        {
            this.damageTypes.Add("Physical");
        }

        public int getDamage()
        {
            return 1;
        }

        public int getCritMod()
        {
            return 2;
        }

        public List<string> getDamageType()
        {
            return damageTypes;
        }
    }
}
