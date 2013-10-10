using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
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
            : this(type, attributeOfAttack, damage, damageTypes)
        {
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
        public Combat()
        {
            //set by input
            Creature[] team1 = new Creature[1];
            Creature[] team2 = new Creature[1];
            //end
            bool battleOn = true;
            while (battleOn)
            {
                //Set up so you get input
                Creature[] orderOfAttack = determineOrder();



            }



        }

        private Creature[] determineOrder(params Creature[] args)
        {
            Creature[] order = new Creature[args.Length];
            foreach (var item in args)
            {
                order.
            }
            return null;
        }

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
                if (defender.getPrimaryAttr("Str") > defender.getPrimaryAttr("Dex"))
                {
                    defenderAttr = defender.getPrimaryAttr("Str");
                    defenceType = "Block";
                }
                else
                {
                    defenderAttr = defender.getPrimaryAttr("Dex");
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
                defenderAttr = defender.getPrimaryAttr("Dex");
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
                if (defender.getPrimaryAttr("Int") > defender.getPrimaryAttr("Dex"))
                {
                    defenderAttr = defender.getInt();
                    defenceType = "Magic Nullification";
                }
                else
                {
                    defenderAttr = defender.getPrimaryAttr("Dex");
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
