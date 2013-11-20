using Duality;
using Duality.EditorHints;
using Engine.Components;
using Engine.Logic;
using System;
using System.Collections.Generic;

namespace Engine.CustomObjects
{
    public class Inventory
    {
        private int gold;
        private Item[] inv;

        public Inventory(int size)
        {
            inv = new Item[size];
        }

        public Inventory(int size, params Item[] items)
        {
            inv = new Item[size];
            foreach (var item in items)
            {
                if (!addToInv(item))
                {
                    throw new FORException("Inventory too small");
                }
            }
        }

        public void setInvSize(int size)
        {
            Item[] temp = inv;
            inv = new Item[size];
            temp.CopyTo(inv, 0);
        }

        public bool addToInv(Item item)
        {
            for (int i = 0; i < this.inv.Length; i++)
            {
                if (inv[i] == null)
                {
                    inv[i] = item;
                    return true;
                }
            }
            return false;
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

    [Serializable]
    public class Stats
    {
        private int _level;
        private int _exp;
        private int _skillPoints;
        private int _strength;
        private int _dexterity;
        private int _vitality;
        private int _intelligence;
        private int _maxHP;
        private int _maxMP;
        private int _hp;
        private int _mp;
        private int _damageModMelee;
        private int _damageModRange;
        private int _damageModMagic;
        private int _damageReduction;
        private int _speed;

        public int Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        public int Exp
        {
            get { return this._exp; }
            set { this._exp = value; }
        }
        public int SkillPoints
        {
            get { return this._skillPoints; }
            set { this._skillPoints = value; }
        }
        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public int Strength
        {
            get { return this._strength; }
            set { this._strength = value; this.updateSecondaryAttributes(); }
        }
        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public int Dexterity
        {
            get { return this._dexterity; }
            set { this._dexterity = value; this.updateSecondaryAttributes(); }
        }
        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public int Vitality
        {
            get { return this._vitality; }
            set { this._vitality = value; this.updateSecondaryAttributes(); }
        }
        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public int Intelligence
        {
            get { return this._intelligence; }
            set { this._intelligence = value; this.updateSecondaryAttributes(); }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int MaxHP
        {
            get { return this._maxHP; }
            private set { this._maxHP = value; }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int MaxMP
        {
            get { return this._maxMP; }
            private set { this._maxMP = value; }
        }
        public int HP
        {
            get { return this._hp; }
            set { this._hp = value; }
        }
        public int MP
        {
            get { return this._mp; }
            set { this._mp = value; }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int DamageModMelee
        {
            get { return this._damageModMelee; }
            private set { this._damageModMelee = value; }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int DamageModRange
        {
            get { return this._damageModRange; }
            private set { this._damageModRange = value; }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int DamageModMagic
        {
            get { return this._damageModMagic; }
            private set { this._damageModMagic = value; }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int DamageReduction
        {
            get { return this._damageReduction; }
            private set { this._damageReduction = value; }
        }
        [EditorHintFlags(MemberFlags.ReadOnly)]
        public int Speed
        {
            get { return this._speed; }
            private set { this._speed = value; }
        }

        public void updateSecondaryAttributes()
        {
            this._maxHP = this._vitality * 4;
            this._hp = this._maxHP;
            this._maxMP = this._intelligence * 4;
            this._mp = this._maxMP;
            this._speed = this._dexterity;
            this._damageModMagic = (this._intelligence - 10) / 2;
            this._damageModMelee = (this._strength - 10) / 2;
            this._damageModRange = (this._dexterity - 10) / 2;
        }

        public override string ToString()
        {
            return "Stats";
        }
    }

    public abstract class Creature
    {
        private static int registeredCreature = 0;

        private int creatureID;
        public string name;
        public int currentTeam;
        public Inventory inventory;
        private Stats stats;

        public Dictionary<string, Item> reward;
        public Dictionary<string, int> rewardNum;

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
            this.Stats = new Stats();
            this.name = name;
            this.Stats.Strength = s;
            this.stats.Dexterity = d;
            this.stats.Vitality = v;
            this.stats.Intelligence = i;
            this.stats.Level = 1;
            this.Stats.updateSecondaryAttributes();
            this.inventory = new Inventory(16);

            this.creatureID = registeredCreature;
            registeredCreature++;
        }

        public Creature(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : this(name, s, d, i, v)
        {
            foreach (var item in resistance)
            {
                setResistance(item.Key, item.Value);
            }
        }

        public bool compareCreature(Creature compared)
        {
            if (this.creatureID == compared.creatureID)
            {
                return true;
            }
            return false;
        }

        public Stats Stats
        {
            get { return this.stats; }
            set { this.stats = value; }
        }

        //Needs to be implemented
        public int getdamageReduction()
        {
            return 0;
        }

        protected void calculateLevel()
        {
            while (true)
            {
                float levelMod = (this.Stats.Level / 10f) * 2;
                if (this.Stats.Exp >= (this.Stats.Level + levelMod) * 800)
                {
                    //Set level up
                }
                else
                {
                    break;
                }
            }
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
                    if (deEquip(slot))
                    {
                        itemsEquipped[slot] = item;
                        return true;
                    }
                    inventory.addToInv(item);
                    return false;
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

        public bool deEquip(string slot)
        {
            if (itemsEquipped[slot] != null)
            {
                if (!inventory.addToInv(itemsEquipped[slot]))
                {
                    return false;
                }
            }
            itemsEquipped[slot] = null;
            return true;
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

        public Inventory Inventory
        {
            get { return this.inventory; }
            set { this.inventory = value; }
        }

        public override string ToString()
        {
            return name;
        }

        //Needs to be implemented for diffrent creatures, remember to put a check on Manapoints for attacks
        public abstract void generateAction(out Ability nextAbility, out int nextTarget, List<GameObject> creatures);
    }

    [Serializable]
    public class Player : Creature
    {
        private AI ai = new playerAI();

        public Player(string name) : base(name) { }

        public Player(string name, int s, int d, int i, int v) : base(name, s, d, i, v) 
        {
        }

        public Player(string name, int s, int d, int i, int v, Dictionary<string, int> resistance) : base(name, s, d, i, v, resistance)
        {
        }

        public override void generateAction(out Ability nextAbility, out int nextTarget, List<GameObject> creatures)
        {
            ai.generateActionCombat(this, creatures);
            nextAbility = ai.NextAbility;
            nextTarget = ai.NextTarget;
            ai.reset();
        }
    }

    [Serializable]
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

        public override void generateAction(out Ability nextAbility, out int nextTarget, List<GameObject> creatures)
        {
            ai.generateActionCombat(this, creatures);
            nextAbility = ai.NextAbility;
            nextTarget = ai.NextTarget;
        }
    }

    [Serializable]
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

        public override void generateAction(out Ability nextAbility, out int nextTarget, List<GameObject> creatures)
        {
            ai.generateActionCombat(this, creatures);
            nextAbility = ai.NextAbility;
            nextTarget = ai.NextTarget;
        }
    }
}
