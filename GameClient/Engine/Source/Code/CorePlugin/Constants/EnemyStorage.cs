using Engine.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Constants
{
    public enum CreatureType
    {
        Player,
        //Enemies
        Skeleton,
        Zombie,
        GiantSpider,

        //Neutral
        Wolf
    }

    public class CreatureStorage
    {
        public static Player Player = new Player("PlayerOne");

        //Enemies
        public static readonly Enemy Skeleton = new Enemy("Skeleton", 11, 13, 3, 8);
        public static readonly Enemy Zombie = new Enemy("Zombie", 13, 8, 3, 9);
        public static readonly Enemy GiantSpider = new Enemy("Giant Spider", 9, 15, 3, 8);

        //Neutral
        public static readonly Enemy Wolf = new Enemy("Wolf", 12, 16, 5, 6);
    }
}
