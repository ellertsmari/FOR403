using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Inventory
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

    public abstract class Creature
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
            {"Speed", 0},
            {"DamageModMelee", 0},
            {"DamageModRange", 0},
            {"DamageModMagic", 0},
            {"DamageReduction", 0}
        };

        protected Dictionary<string, Item> itemsEquipped = new Dictionary<string, Item>()
        {
            {"Head", null},
            {"Main-Hand", null},
            {"Off-Hand", null},
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
            secAttr["MaxHP"] = primaryAttr["Vit"] * 4;
            secAttr["HP"] = secAttr["MaxHP"];
            secAttr["MaxMP"] = primaryAttr["Int"] * 4;
            secAttr["MP"] = secAttr["MaxMP"];
            secAttr["Speed"] = primaryAttr["Dex"];
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

        public void setLevel(int lvl)
        {
            this.level = lvl;
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
                return itemsEquipped[slot];
            }
            throw new FORException("slot is wrong");
        }

        public bool setEquip(string slot, Item item)
        {
            if (itemsEquipped.ContainsKey(slot) && (item.getEquipSlot() == slot || (item.getEquipSlot() == "One-Handed" && (slot == "RightArm" || slot == "LeftArm"))))
            {
                if (inventory.removeFromInv(item))
                {
                    if (itemsEquipped[slot] != null)
                    {
                        if (!inventory.addToInv(itemsEquipped[slot]))
                        {
                            inventory.addToInv(item);
                            return false;
                        }
                    }

                    itemsEquipped[slot] = item;
                    return true;
                }
            }
            else if (slot == "Main-Hand" && (item.getEquipSlot() == "Two-Handed"))
            {
                if (inventory.removeFromInv(item))
                {
                    bool temp = false;
                    if (itemsEquipped[slot] != null)
                    {
                        temp = true;
                        if (!inventory.addToInv(itemsEquipped[slot]))
                        {
                            inventory.addToInv(item);
                            return false;
                        }
                    }

                    if (itemsEquipped["Off-Hand"] != null)
                    {
                        if (!inventory.addToInv(itemsEquipped["Off-Hand"]))
                        {
                            if (temp)
                            {
                                inventory.removeFromInv(itemsEquipped[slot]);
                            }
                            inventory.addToInv(item);
                            return false;
                        }
                    }

                    itemsEquipped[slot] = item;
                    itemsEquipped["Off-Hand"] = null;
                    return true;
                }
            }
            return false;
        }

        public bool setEquipAdmin(string slot, Item item)
        {
            if (itemsEquipped.ContainsKey(slot) && (item.getEquipSlot() == slot || (item.getEquipSlot() == "One-Handed" && (slot == "Main-Hand" || slot == "Off-Hand"))))
            {
                if (itemsEquipped[slot] != null)
                {
                    if (!inventory.addToInv(itemsEquipped[slot]))
                    {
                        inventory.addToInv(item);
                        return false;
                    }
                }

                itemsEquipped[slot] = item;
                return true;
            }
            else if (slot == "Main-Hand" && (item.getEquipSlot() == "Two-Handed"))
            {
                bool temp = false;
                if (itemsEquipped[slot] != null)
                {
                    temp = true;
                    if (!inventory.addToInv(itemsEquipped[slot]))
                    {
                        inventory.addToInv(item);
                        return false;
                    }
                }

                if (itemsEquipped["Off-Hand"] != null)
                {
                    if (!inventory.addToInv(itemsEquipped["Off-Hand"]))
                    {
                        if (temp)
                        {
                            inventory.removeFromInv(itemsEquipped[slot]);
                        }
                        inventory.addToInv(item);
                        return false;
                    }
                }

                itemsEquipped[slot] = item;
                itemsEquipped["Off-Hand"] = null;
                return true;
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
        public abstract void generateAction(out Ability value1AI, out int value2AI, Creature[] creatures, int myPlaceInCreature);
    }

    public class Player : Creature
    {
        public Player(string name) : base(name) { }

        public Player(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
        }

        public Player(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
        }

        public override void generateAction(out Ability value1AI, out int value2AI, Creature[] creatures, int myPlaceInCreature)
        {
            throw new NotImplementedException();
        }
    }

    public class NPC : Creature
    {
        private AI ai = new defultAI();

        public NPC(string name) : base(name)
        {
        }

        public NPC(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
        }

        public NPC(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
        }

        public override void generateAction(out Ability nextAbility, out int nextTarget, Creature[] creatures, int myPlaceInCreature)
        {
            ai.generateActionCombat(this, creatures, myPlaceInCreature);
            nextAbility = ai.nextAbility;
            nextTarget = ai.nextTarget;
        }
    }

    public enum Enemies
    {

    }

    public class Enemy : Creature
    {
        private static List<Enemy> instances = new List<Enemy>();
        public static IEnumerable<Enemy> Instances
        {
            get { return instances; }
        }

        public AI ai {get; set;}

        public Enemy(string name) : base(name) { ai = new defultAI();}

        public Enemy(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
            ai = new defultAI();
        }

        public Enemy(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
            ai = new defultAI();
        }

        public override void generateAction(out Ability nextAbility, out int nextTarget, Creature[] creatures, int myPlaceInCreature)
        {
            ai.generateActionCombat(this, creatures, myPlaceInCreature);
            nextAbility = ai.nextAbility;
            nextTarget = ai.nextTarget;
        }
    }
}
