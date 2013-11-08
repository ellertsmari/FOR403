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
        public static Random RANDOM = new Random();
        public Player player;

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
            Creature cre1 = new NPC("Peasant", 10, 12, 9, 5);
            Creature cre3 = new NPC("Peasant", 10, 12, 9, 5);
            Creature cre2 = new NPC("Drunkard", 12, 9, 8, 6);
            cre2.setEquipAdmin("Off-Hand", new ItemShield("Off-Hand", 40));
            Combat combat = new Combat(new Creature[] { cre1, cre3 }, new Creature[] { cre2 }, false);
            Console.ReadLine();
        }
    }

    public class FORException : Exception
    {
        public FORException() : base() { }
        public FORException(string message) : base(message) { }
        public FORException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class Message
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
}
