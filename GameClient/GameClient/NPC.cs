using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    class Creature
    {
        protected int level;
        protected int exp;
        protected int skillPoints;

        protected Dictionary<string, int> primaryAttr = new Dictionary<string, int>()
        {
            {"Str", 0},
            {"Dex", 0},
            {"Int", 0},
            {"Vit", 0}
        };

        protected Dictionary<string, int> itemAdd = new Dictionary<string, int>()
        {
            {"MaxHP", 0},
            {"MaxMP", 0},
            {"Str", 0},
            {"Dex", 0},
            {"Int", 0},
            {"Vit", 0},
            {"DamageReduction", 0}
        };

        protected Dictionary<string, int> secAttr = new Dictionary<string, int>()
        {
            {"MaxHP", 0},
            {"HP", 0},
            {"MaxMP", 0},
            {"MP", 0},
            {"DamageModMelee", 0},
            {"DamageModRange", 0},
            {"DamageModMagic", 0},
            {"DamageReduction", 0}
        };

        protected Dictionary<string, Item> itemsEquipped = new Dictionary<string, Item>()
        {
            {"Head", null},
            {"RightArm", null},
            {"LeftArm", null},
            {"Chest", null},
            {"RightLeg", null},
            {"LeftLeg", null}
        };

        protected Dictionary<string, int> resistance;

        public Creature()
        {

        }

        public void addStr(int Str)
        {
            primaryAttr["Str"] += Str;
            updateSecondaryAttributes();
        }

        public void addDex(int Dex)
        {
            primaryAttr["Dex"] += Dex;
            updateSecondaryAttributes();
        }

        public void addInt(int Int)
        {
            primaryAttr["Int"] += Int;
            updateSecondaryAttributes();
        }

        public void addVit(int Vit)
        {
            primaryAttr["Vit"] += Vit;
            updateSecondaryAttributes();
        }

        protected void updateSecondaryAttributes()
        {
            secAttr["MaxHP"] = getPrimaryAttr("Vit") * 10;
            secAttr["HP"] = secAttr["MaxHP"];
            secAttr["MaxMP"] = getPrimaryAttr("Int") * 10;
            secAttr["MP"] = secAttr["MaxMP"];
            secAttr["DamageModMagic"] = level * (primaryAttr["Int"] + 10) / 10;
            secAttr["DamageModMelee"] = (primaryAttr["Str"] + 10) / 2;
            secAttr["DamageModRange"] = (primaryAttr["Dex"] + 10) / 2;
        }

        public int getdamageReduction()
        {
            return 0;
        }

        public void giveExp(int exp)
        {
            this.exp += exp;
            calculateLevel();
        }

        public void takeExp(int exp)
        {
            this.exp -= exp;
            calculateLevel();
        }

        protected void calculateLevel()
        {
            while (true)
            {
                float levelMod = (level / 10f) * 2;
                if (exp >= (level + levelMod) * 800)
                {
                    //Set level up
                }
                else
                {
                    break;
                }
            }
        }

        public int getLevel()
        {
            return level;
        }

        public Dictionary<string, int> getResistance()
        {
            return resistance;
        }

        public int getPrimaryAttr(string priAttr)
        {
            int ret = primaryAttr[priAttr];
            if (itemAdd.ContainsKey(priAttr))
            {
                ret += itemAdd[priAttr];
            }

            return ret;
        }

        public int getSecondAttr(string secondAttr)
        {
            int ret = secAttr[secondAttr];
            if (itemAdd.ContainsKey(secondAttr))
            {
                ret += itemAdd[secondAttr];
            }

            return ret;
        }

        public Item getEquip(string slot)
        {
            if (itemsEquipped.ContainsKey(slot))
            {

            }
            return null;
        }

        public void setEquip(string slot, Item item)
        {
            if (itemsEquipped.ContainsKey(slot))
            {
                removeFromInventory(item);
                addToInventory(itemsEquipped[slot]);
                itemsEquipped[slot] = item;
            }
        }

        public void addToInventory(Item item)
        {

        }

        public void removeFromInventory(int slot)
        {

        }

        public void removeFromInventory(Item item)
        {

        }
    }

    class Player : Creature
    {

    }

    class NPC : Creature
    {

    }

    class Enemy : Creature
    {

    }
}
