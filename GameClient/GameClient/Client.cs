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

    class Creature
    {
        protected int level;
        protected int exp;

        protected int MaxHP;
        protected int HP;
        protected int MP;
        protected int Str;
        protected int Dex;
        protected int Int;

        protected int DamageModMelee;
        protected int DamageModRange;
        protected int DamageModMagic;

        protected Dictionary<string, int> resistance;

        public Creature()
        {

        }

        public void addMaxHP(int MaxHP)
        {
            this.MaxHP += MaxHP;
            this.HP = this.MaxHP;
        }

        public void addHP(int HP)
        {
            this.HP += HP;
        }

        public void addMP(int MP)
        {
            this.MP += MP;
        }

        public void addStr(int Str)
        {
            this.Str += Str;
            updateSecondaryAttributes();
        }

        public void addDex(int Dex)
        {
            this.Dex += Dex;
            updateSecondaryAttributes();
        }

        public void addInt(int Int)
        {
            this.Int += Int;
            updateSecondaryAttributes();
        }

        protected void updateSecondaryAttributes()
        {
            this.DamageModMagic = level*(this.Int + 10)/10;
            this.DamageModMelee = (this.Str + 10) / 2;
            this.DamageModRange = (this.Dex + 10) / 2;
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
            return HP;
        }

        public int getMP()
        {
            return MP;
        }

        public int getStr()
        {
            return Str;
        }

        public int getDex()
        {
            return Dex;
        }

        public int getInt()
        {
            return Int;
        }

        public Dictionary<string, int> getResistance()
        {
            return resistance;
        }

        public int getDamageModMelee()
        {
            return DamageModMelee;
        }

        public int getDamageModRange()
        {
            return DamageModRange;
        }

        public int getDamageModMagic()
        {
            return DamageModMagic;
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
        private int attributeOfAttack;
        private List<string> damageType;
        private int damage;

        public Attack(string type, int attributeOfAttack, int damage, params string[] damageTypes)
        {
            this.type = type;
            this.attributeOfAttack = attributeOfAttack;
            this.damage = damage;
            this.damageType = new List<string>(damageTypes);
        }

        public string getType()
        {
            return type;
        }

        public int getAttr()
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
    }

    class Combat
    {
        public static Result Battle(Creature attacker, Attack attack, Creature defender)
        {
            int resultDamage = 0;
            if (attack.getPiercing() = false)
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
                    chance = (attack.getAttr() / 2 / defenderAttr + defender.getShield().getBlock()) * 100
                    defenceType = "Block";
                }
                else
                {
                    chance = (attack.getAttr() / 2 / defenderAttr) * 100;
                }
            }
            else if (attack.getType() == "Range")
            {
                int defenderAttr;
                defenderAttr = defender.getDex();
                defenceType = "Dodge";

                if (defender.hasShield() == true)
                {
                    chance = (attack.getAttr() / 2 / defenderAttr + defender.getShield().getBlock()) * 100
                    defenceType = "Block";
                }
                else
                {
                    chance = (attack.getAttr() / 2 / defenderAttr) * 100;
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
                chance = (attack.getAttr() / 2 / defenderAttr) * 100;
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
