using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    class Result
    {
        public string result;
        public int damage;
        public string damageAttr;

        public Result(string result) : this(result, 0, "HP") {}

        public Result(string result, int damage) : this(result, damage, "HP") { }

        public Result(string result, int damage, string damageAttr)
        {
            this.result = result;
            this.damage = damage;
            this.damageAttr = damageAttr;
        }

        public override string ToString()
        {
            if (result == "Hit")
            {
                return result + " " + damage;
            }
            else
            {
                return result;
            }
        }
    }

    class Attack
    {
        public string type;
        public string attributeOfAttack;
        public List<string> damageType;
        public int damage;
        public int placeOfVictim;
        public bool piercing;

        //type: Melee, Range or Magic; attributeOfAttack: Str, Dex or Int; damage: damage of attack; damageTypes: what type of attack it is Ex: Physical
        public Attack(string type, string attributeOfAttack, int damage, int placeOfVictim, params string[] damageTypes)
        {
            this.type = type;
            this.attributeOfAttack = attributeOfAttack;
            this.placeOfVictim = placeOfVictim;
            this.damage = damage;
            this.damageType = new List<string>(damageTypes);
        }

        public Attack(string type, string attributeOfAttack, int damage, bool piercing, int placeOfVictim, params string[] damageTypes)
            : this(type, attributeOfAttack, damage, placeOfVictim, damageTypes)
        {
            this.piercing = piercing;
        }
    }

    class Combat
    {
        private Creature[] team1;
        private Creature[] team2;
        private Creature[] creatures;
        private int winningTeam;
        private bool isReward;

        public Combat(Creature[] team1, Creature[] team2) : this(team1, team2, true) {}

        public Combat(Creature[] team1, Creature[] team2, bool reward)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.isReward = reward;
            initCombat();
            this.winningTeam = runCombat();
        }

        //initializes combat, always run before runCombat
        private void initCombat()
        {
            foreach (var item in team1)
            {
                item.currentTeam = 1;
            }

            foreach (var item in team2)
            {
                item.currentTeam = 2;
            }

            //Determine order of attack by Dex
            creatures = new Creature[team1.Length + team2.Length];
            Array.Copy(team1, creatures, team1.Length);
            Array.Copy(team2, 0, creatures, team1.Length, team2.Length);
            creatures = determineOrder(creatures);
        }

        //Starts the combat loop
        public int runCombat()
        {
            //end
            bool battleOn = true;
            int cycle = 0;

            //Battle loop, stops when one team is dead.
            while (battleOn)
            {
                Attack nextAttack = creatures[cycle].getNextAttack();
                if (nextAttack == null)
                {
                    nextAttack = creatures.generateAttack();
                }

                if ((creatures[cycle].getSecondAttr("HP") > 0))
                {
                    Result outcome;

                    if (nextAttack == null)
                    {
                        outcome = new Result("Stunned");
                    }
                    else if (nextAttack.type == "Run Away")
                    {
                        //implement code to run away
                    }
                    else
                    {
                        //Run animation for attack here
                        outcome = Battle(creatures[cycle], nextAttack, creatures[nextAttack.placeOfVictim]);
                    }

                    //Needs to implement a method to print message result to screen
                    //Screen.print(outcome)
                    creatures[nextAttack.placeOfVictim].setSecondAttr("HP", creatures[nextAttack.placeOfVictim].getSecondAttr("HP") - outcome.damage);
                    int won = this.update();
                    if (won == 1)
                    {
                        checkReward();
                        return 1;
                    }
                    else if (won == 2)
                    {
                        checkReward();
                        return 2;
                    }
                    this.render();
                }

                //Gets the next creature in the cycle
                cycle++;
                if (cycle == creatures.Length)
                {
                    cycle = 0;
                }
            }

            return 0;
        }

        //Determines order of attack by the dex variable of every creature in the args argument
        private Creature[] determineOrder(params Creature[] args)
        {
            Creature[] order = new Creature[args.Length];
            int start = 0;
            foreach (var item in args)
            {
                order[start] = item;
                start++;
            }
            Array.Sort(order, delegate(Creature x, Creature y) { return x.getPrimaryAttr("Dex").CompareTo(y.getPrimaryAttr("Dex")); });
            return order;
        }

        //Does the calculations behind every attack
        private static Result Battle(Creature attacker, Attack attack, Creature defender)
        {
            int resultDamage = attack.damage + attacker.getSecondAttr("DamageMod" + attack.type);
            if (attack.piercing == false)
            {
                resultDamage = attack.damage - defender.getdamageReduction();
            }
            else
            {
                resultDamage = attack.damage;
            }

            List<string> resultDamageType = attack.damageType;

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
            else if (attack.type == "Melee") //Melee
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

                if (defender.getEquip("LeftArm").isShield())
                {
                    chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr + defender.getEquip("LeftArm").getBlock()) * 100
                    defenceType = "Block";
                }
                else
                {
                    chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr) * 100;
                }
            }
            else if (attack.type == "Range") //Ranged
            {
                int defenderAttr;
                defenderAttr = defender.getPrimaryAttr("Dex");
                defenceType = "Dodge";

                if (defender.getEquip("LeftArm").isShield())
                {
                    chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr + defender.getEquip("LeftArm").getBlock()) * 100;
                    defenceType = "Block";
                }
                else
                {
                    chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr) * 100;
                }
            }
            else //Magic
            {
                int defenderAttr;
                if (defender.getPrimaryAttr("Int") > defender.getPrimaryAttr("Dex"))
                {
                    defenderAttr = defender.getPrimaryAttr("Int");
                    defenceType = "Magic Nullification";
                }
                else
                {
                    defenderAttr = defender.getPrimaryAttr("Dex");
                    defenceType = "Dodge";
                }
                chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr) * 100;
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

        private void checkReward()
        {
            if (this.isReward)
            {
                Creature[] give;
                Creature[] take;
                Item[] rewardItems;
                int rewardGold = 0;
                int rewardEXP = 0;

                if (winningTeam == 1)
                {
                    give = this.team1;
                    take = this.team2;
                }
                else
                {
                    give = this.team2;
                    take = this.team1;
                }

                List<Item> list = new List<Item>();
                foreach (var creature in take)
                {
                    if (creature.reward != null)
                    {
                        foreach (var item in creature.reward)
                        {
                            list.Add(item.Value);
                        }
                    }
                    if (creature.rewardNum != null)
                    {
                        foreach (var item in creature.rewardNum)
                        {
                            if (item.Key == "EXP")
                            {
                                rewardEXP += item.Value;
                            }
                            else if (item.Key == "Gold")
                            {
                                rewardGold += item.Value;
                            }
                        }
                    }
                }

                rewardItems = list.ToArray();
                list = null;

                foreach (var creature in give)
                {
                    creature.giveExp(rewardEXP);
                    if (creature is Player)
                    {
                        creature.inventory.addGold(rewardGold);
                        creature.inventory.openInvWindow(new Inventory(rewardItems));
                    }
                }
            }
        }

        //Checks if battle is done or not
        private int update()
        {
            int t1 = 0;
            int t2 = 0;

            foreach (var creature in creatures)
            {
                if (creature.currentTeam == 1)
                {
                    t1++;
                }
                else
                {
                    t2++;
                }
            }

            if (t1 == 0)
            {
                return 1;
            }
            else if (t2 == 0)
            {
                return 2;
            }

            return 0;
        }

        //renders the battlefield and creatures if they are alive.
        private void render()
        {

        }
    }
}
