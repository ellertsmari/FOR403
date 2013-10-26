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
            cre2.setEquipAdmin("Off-Hand", new ItemShield("Off-Hand", 40));
            Combat combat = new Combat(new Creature[] { cre1 }, new Creature[] { cre2 }, false);
            Console.ReadLine();
        }
    }

    class FORException : Exception
    {
        public FORException() : base() { }
        public FORException(string message) : base(message) { }
        public FORException(string message, System.Exception inner) : base(message, inner) { }
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

    abstract class Item
    {
        protected Dictionary<string, int> itemAttributes = null;
        protected string equipSlot;

        public Item(string equipSlot)
        {
            string[] possibleSlots = new string[]
            {
                "Head",
                "Main-Hand",
                "Off-Hand",
                "Chest",
                "RightLeg",
                "LeftLeg"
            };

            bool exec = true;
            foreach (var slot in possibleSlots)
            {
                if (slot == equipSlot)
                {
                    exec = false;
                    break;
                }
            }
            if (exec)
            {
                throw new FORException("Slot in item does not exist");
            }
            else
            {
                this.equipSlot = equipSlot;
            }
        }

        public int getItemAttribute(string attribute)
        {
            return itemAttributes[attribute];
        }

        public string getEquipSlot()
        {
            return equipSlot;
        }
    }

    class ItemShield : Item
    {
        int blockPercentage;

        public ItemShield(string equipSlot, int blockPercentage) : base(equipSlot)
        {
            this.blockPercentage = blockPercentage;
        }

        public int getBlock()
        {
            return blockPercentage;
        }
    }

    class ItemWeapon : Item
    {
        private List<string> damageTypes = new List<string>();

        public ItemWeapon(string equipSlot) : base(equipSlot)
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
