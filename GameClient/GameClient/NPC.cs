using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Inventory
    {
        private int gold;
        private Item[] inv;

        public Inventory(int size)
        {
            inv = new Item[size];
        }

        public Inventory(params Item[] items)
        {
            inv = items;
        }

        public void setInvSize(int size)
        {
            Item[] temp = inv;
            inv = new Item[size];
            temp.CopyTo(inv, 0);
        }

        public bool addToInv(Item item)
        {
            bool added = false;
            for (int i = 0; i < this.inv.Length; i++)
            {
                if (inv[i] == null)
                {
                    inv[i] = item;
                    added = true;
                    break;
                }
            }
            if (added)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeFromInv(int index)
        {
            try
            {
                if (this.inv[index] == null)
                {
                    return false;
                }
                this.inv[index] = null;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }
        
        public bool removeFromInv(Item item)
        {
            for (int i = 0; i < this.inv.Length; i++)
            {
                if (this.inv[i] == item)
                {
                    this.inv[i] = null;
                    return true;
                }
            }
            return false;
        }

        public int getInvSize()
        {
            return inv.Length;
        }

        public void addGold(int gold)
        {
            this.gold += gold;
        }

        public int getGold()
        {
            return this.gold;
        }

        public void openInvWindow(Inventory inventory)
        {
            //Opens an inv window to switch between inventories
        }
    }

    abstract class Creature
    {
        public string name;
        public int currentTeam;
        protected int level;
        protected int exp;
        protected int skillPoints;
        public Position position;
        public Inventory inventory;

        public Dictionary<string, Item> reward;
        public Dictionary<string, int> rewardNum;

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

        public List<Ability> abilities = new List<Ability>();

        //If values are set to - then they work like the attribute is super effective against them
        //for example -400 physical resistance adds 400% more damage to pure physical attacks against him
        protected Dictionary<string, int> resistance = new Dictionary<string, int>()
        {
            {"Physical", 0},
            {"Fire", 0},
            {"Earth", 0},
            {"Water", 0},
            {"Wind", 0},
            {"Dark", 0},
            {"Light", 0},
            {"Void", 0}
        };

        public Creature(string name) : this(name, 2, 2, 2, 2) {}

        public Creature(string name, int s, int d, int i, int v)
        {
            this.name = name;
            primaryAttr["Str"] = s;
            primaryAttr["Dex"] = d;
            primaryAttr["Int"] = i;
            primaryAttr["Vit"] = v;
            updateSecondaryAttributes();
            this.level = 1;
        }

        public Creature(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : this(name, s, d, i, v)
        {
            foreach (var item in resistance)
            {
                setResistance(item.Key, item.Value);
            }
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
            secAttr["MaxHP"] = getPrimaryAttr("Vit") * 4;
            secAttr["HP"] = secAttr["MaxHP"];
            secAttr["MaxMP"] = getPrimaryAttr("Int") * 4;
            secAttr["MP"] = secAttr["MaxMP"];
            secAttr["DamageModMagic"] = (primaryAttr["Int"] - 10) / 2;
            secAttr["DamageModMelee"] = (primaryAttr["Str"] - 10) / 2;
            secAttr["DamageModRange"] = (primaryAttr["Dex"] - 10) / 2;
        }

        //Needs to be implemented
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

        public void setResistance(string key, int value)
        {
            if (value > 100)
            {
                throw new FORException("Value too high for resistance");
            }

            if (this.resistance.ContainsKey(key))
            {
                this.resistance[key] = value;
            }
            else
            {
                this.resistance.Add(key, value);
            }
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

        public void setPrimaryAttr(string priAttr, int num)
        {
            primaryAttr[priAttr] = num;
        }

        public void setSecondAttr(string secondAttr, int num)
        {
            secAttr[secondAttr] = num;
        }

        public void addAbility(Ability ability)
        {
            abilities.Add(ability);
        }

        public bool rmAbility(Ability ability)
        {
            return abilities.Remove(ability);
        }

        public Item getEquip(string slot)
        {
            if (itemsEquipped.ContainsKey(slot))
            {

            }
            return null;
        }

        public bool setEquip(string slot, Item item)
        {
            if (itemsEquipped.ContainsKey(slot) && item.getEquipSlot() == slot)
            {
                if (inventory.removeFromInv(item))
                {
                    itemsEquipped[slot] = item;
                    return true;
                }
            }
            return false;
        }

        public Inventory getInventory()
        {
            return inventory;
        }

        public override string ToString()
        {
            return name;
        }

        //Needs to be implemented for diffrent creatures, remember to put a check on Manapoints for attacks
        public abstract Ability generateAbility();

        public abstract int chooseTarget(Creature[] creature, int myPlaceInCreature, Ability ability);
    }

    class Player : Creature
    {
        public Player(string name) : base(name) { }

        public Player(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
        }

        public Player(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
        }

        public override Ability generateAbility()
        {
            return null;
        }

        public override int chooseTarget(Creature[] creature, int myPlaceInCreature, Ability ability)
        {
            return 0;
        }
    }

    class NPC : Creature
    {
        public NPC(string name) : base(name)
        {
        }

        public NPC(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
        }

        public NPC(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
        }

        public override Ability generateAbility()
        {
            if (abilities.Count == 0)
            {
                return AbilityStorage.MELEE["Punch"];
            }
            else
            {
                //Put call to AI here
                return abilities[0];
            }
        }

        //replace later to put AI code here
        public override int chooseTarget(Creature[] creatures, int myPlaceInCreature, Ability ability)
        {
            Random rand = new Random();

            int lookFor = 0;
            if (ability.victimType == "Enemy")
            {
                lookFor = this.currentTeam;
            }
            else if (ability.victimType == "Ally")
            {
                if (this.currentTeam == 1)
                {
                    lookFor = 2;
                }
                else
                {
                    lookFor = 1;
                }
            }

            while (true)
            {
                int target = rand.Next(creatures.Length);
                if ((creatures[target].getSecondAttr("HP") > 0) && (target != myPlaceInCreature) && (creatures[target].currentTeam != lookFor))
                {
                    return target;
                }
            }
        }
    }

    class Enemy : Creature
    {
        public Enemy(string name) : base(name) { }

        public Enemy(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
        }

        public Enemy(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
        }

        public override Ability generateAbility()
        {
            return null;
        }

        public override int chooseTarget(Creature[] creature, int myPlaceInCreature, Ability ability)
        {
            return 0;
        }
    }
}
