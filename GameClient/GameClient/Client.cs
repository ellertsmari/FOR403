using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    public class Client
    {

    }

    class Item
    {
        public Item()
        {

        }
    }

    class Creature
    {
        protected int level;
        protected int exp;

        protected Dictionary<string, int> primaryAttr = new Dictionary<string, int>()
        {
            {"MaxHP", 0},
            {"HP", 0},
            {"MaxMP", 0},
            {"MP", 0},
            {"Str", 0},
            {"Dex", 0},
            {"Int", 0}
        };

        protected Dictionary<string, int> secAttr = new Dictionary<string, int>()
        {
            {"DamageModMelee", 0},
            {"DamageModRange", 0},
            {"DamageModMagic", 0}
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

        public void addMaxHP(int MaxHP)
        {
            primaryAttr["MaxHP"] += MaxHP;
            primaryAttr["HP"] = primaryAttr["MaxHP"];
        }

        public void addHP(int HP)
        {
            primaryAttr["HP"] += HP;
        }

        public void addMaxMP(int MaxMP)
        {
            primaryAttr["MaxMP"] += MaxMP;
            primaryAttr["MP"] = primaryAttr["MaxMP"];
        }

        public void addMP(int MP)
        {
            primaryAttr["MP"] += MP;
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

        protected void updateSecondaryAttributes()
        {
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
                float levelMod = (level/10f)*2;
                if (exp >= (level+levelMod)*800)
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

        public int getHP()
        {
            return primaryAttr["HP"];
        }

        public int getMP()
        {
            return primaryAttr["MP"];
        }

        public int getStr()
        {
            return primaryAttr["Str"];
        }

        public int getDex()
        {
            return primaryAttr["Dex"];
        }

        public int getInt()
        {
            return primaryAttr["Int"];
        }

        public Dictionary<string, int> getResistance()
        {
            return resistance;
        }

        public int getDamageModMelee()
        {
            return secAttr["DamageModMelee"];
        }

        public int getDamageModRange()
        {
            return secAttr["DamageModRange"];
        }

        public int getDamageModMagic()
        {
            return secAttr["DamageModMagic"];
        }

        public int getPrimaryAttr(string primaryAttr)
        {
            return primaryAttr[primaryAttr];
        }

        public int getSecondAttr(string secondAttr)
        {
            return secAttr[secondAttr];
        }
    }

    class Player : Creature
    {

    }

    class Enemy : Creature
    {

    }

    class Result
    {
        string result;
        int damage;

        public Result(string result)
        {
            this.result = result;
            damage = 0;
        }

        public Result(string result, int damage)
        {
            this.result = result;
            this.damage = damage;
        }
    }

    class Attack
    {
        private string type;
        private string attributeOfAttack;
        private List<string> damageType;
        private int damage;
        private bool piercing;

        //type: Melee, Range or Magic; attributeOfAttack: Str, Dex or Int; damage: damage of attack; damageTypes: what type of attack it is Ex: Physical
        public Attack(string type, string attributeOfAttack, int damage, params string[] damageTypes)
        {
            this.type = type;
            this.attributeOfAttack = attributeOfAttack;
            this.damage = damage;
            this.damageType = new List<string>(damageTypes);
        }

        public Attack(string type, string attributeOfAttack, int damage, bool piercing, params string[] damageTypes)
        {
            this(type, attributeOfAttack, damage, damageTypes);
            this.piercing = piercing;
        }

        public string getType()
        {
            return type;
        }

        public string getAttr()
        {
            return attributeOfAttack;
        }

        public List<string> getDamageType()
        {
            return damageType;
        }

        public int getDamage()
        {
            return damage;
        }

        public bool getPiercing()
        {
            return piercing;
        }
    }

    class Combat
    {
        public static Result Battle(Creature attacker, Attack attack, Creature defender)
        {
            int resultDamage = attack.getDamage() + attacker.getSecondAttr("DamageMod" + attack.getType());
            if (attack.getPiercing() == false)
            {
                resultDamage = attack.getDamage() - defender.getdamageReduction();
            }
            else
            {
                resultDamage = attack.getDamage();
            }

            List<string> resultDamageType = attack.getDamageType();

            int resistancePercent;
            int count = resultDamageType.Count;
            for (int i = 0; i < resultDamageType.Count; i++)
            {
                if (defender.getResistance().ContainsKey(resultDamageType[i]))
                {
                    resistancePercent += defender.getResistance()[resultDamageType[i]]/count;
                }
            }
            if (resistancePercent > 100)
            {
                resistancePercent = 100;
            }
            resultDamage *= (100-resistancePercent)/100;

            string defenceType;
            int chance = 0;

            if (resultDamage <= 0)
            {
                return new Result("Immune");
            }
            else if (chance != 0)
            {
                
            }
            else if (attack.getType() == "Melee")
            {
                int defenderAttr;
                if (defender.getStr() > defender.getDex())
                {
                    defenderAttr = defender.getStr();
                    defenceType = "Block";
                }
                else
                {
                    defenderAttr = defender.getDex();
                    defenceType = "Dodge";
                }

                if (defender.hasShield() == true)
                {
                    chance = (attacker.getPrimaryAttr(attack.getAttr()) / 2 / defenderAttr + defender.getShield().getBlock()) * 100
                    defenceType = "Block";
                }
                else
                {
                    chance = (attacker.getPrimaryAttr(attack.getAttr()) / 2 / defenderAttr) * 100;
                }
            }
            else if (attack.getType() == "Range")
            {
                int defenderAttr;
                defenderAttr = defender.getDex();
                defenceType = "Dodge";

                if (defender.hasShield() == true)
                {
                    chance = (attacker.getPrimaryAttr(attack.getAttr()) / 2 / defenderAttr + defender.getShield().getBlock()) * 100
                    defenceType = "Block";
                }
                else
                {
                    chance = (attacker.getPrimaryAttr(attack.getAttr()) / 2 / defenderAttr) * 100;
                }
            }
            else //Magic
            {
                int defenderAttr;
                if (defender.getInt() > defender.getDex())
                {
                    defenderAttr = defender.getInt();
                    defenceType = "Magic Nullification";
                }
                else
                {
                    defenderAttr = defender.getDex();
                    defenceType = "Dodge";
                }
                chance = (attacker.getPrimaryAttr(attack.getAttr()) / 2 / defenderAttr) * 100;
            }

            Random rand = new Random();
            if (chance >= (rand.NextDouble()*100))
            {
                defenceType = "Hit";
            }
            else
            {
                resultDamage = 0;
            }
            return new Result(defenceType, resultDamage);
        }
    }
}
