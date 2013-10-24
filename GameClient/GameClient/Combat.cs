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
        public static Dictionary<string, Attack> MELEE = new Dictionary<string, Attack>
                                {
                                    {"Punch", new Attack("Melee", "Str", 2, false, "Enemy", "Physical")},
                                    {"Kick", new Attack("Melee", "Str", 4, false, "Enemy", "Physical")}
                                    
                                    
                                };
        public static Dictionary<string, Attack> RANGE = new Dictionary<string, Attack>
                                {
                                    {"Arrow shot", new Attack("Melee", "Dex", 7, true, "Enemy", "Physical")}



                                };
        public static Dictionary<string, Attack> MAGIC = new Dictionary<string, Attack>
                                {
                                    {"Heal", new Attack("Magic", "int", 4, false, 12, true, "Enemy", "Physical")}



                                };

        public string type;
        public string attributeOfAttack;
        public List<string> damageType;
        public bool positiveDamage;
        public int damage;
        public string victimType;
        public bool piercing;
        public int MPCost;

        //type: Melee, Range or Magic; attributeOfAttack: Str, Dex or Int; damage: damage of attack; damageTypes: what type of attack it is Ex: Physical
        public Attack(string type, string attributeOfAttack, int damage, string victimType, params string[] damageTypes)
        {
            this.type = type;
            this.attributeOfAttack = attributeOfAttack;
            this.victimType = victimType;
            this.damage = damage;
            this.damageType = new List<string>(damageTypes);
            this.piercing = false;
            MPCost = 0;
            this.positiveDamage = false;
        }

        public Attack(string type, string attributeOfAttack, int damage, bool piercing, string victimType, params string[] damageTypes)
            : this(type, attributeOfAttack, damage, victimType, damageTypes)
        {
            this.piercing = piercing;
        }

        public Attack(string type, string attributeOfAttack, int damage, bool piercing, int MPCost, bool positiveDamage, string victimType, params string[] damageTypes)
            : this(type, attributeOfAttack, damage, piercing, victimType, damageTypes)
        {
            this.MPCost = MPCost;
            this.positiveDamage = positiveDamage;
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
                int target = 0;

                if (nextAttack == null)
                {
                    nextAttack = creatures[cycle].generateAttack();
                    target = creatures[cycle].chooseTarget(creatures, cycle, nextAttack);
                    
                }

                if (creatures[cycle].getSecondAttr("HP") > 0)
                {
                    Result outcome = null;
                    bool skip = false;

                    if (nextAttack == null)
                    {
                        Message.sendMessagePlayer(creatures[cycle] + " is stunned");
                        outcome = new Result("Stunned");
                        skip = true;
                    }
                    else if (nextAttack.type == "Run Away")
                    {
                        Message.sendMessagePlayer("Team " + creatures[cycle].currentTeam + " runs away");
                        //implement code to run away
                    }
                    else
                    {
                        outcome = Battle(creatures[cycle], nextAttack, creatures[target]);
                        if (outcome.result == "Hit")
                        {
                            Message.sendMessagePlayer(creatures[target] + " is Hit for " + outcome.damage + " damage");
                        }
                        else
                        {
                            Message.sendMessagePlayer(creatures[target] + outcome.result);
                        }
                        //Run animation for attack here
                    }

                    if (skip)
                    {
                        //Needs to implement a method to print message result to screen
                        //Screen.print(outcome)
                        if (nextAttack.positiveDamage)
                        {
                            creatures[target].setSecondAttr("HP", creatures[target].getSecondAttr("HP") + outcome.damage);
                            if (creatures[target].getSecondAttr("HP") > creatures[target].getSecondAttr("MaxHP"))
                            {
                                creatures[target].setSecondAttr("HP", creatures[target].getSecondAttr("MaxHP"));
                            }
                        }
                        else
                        {
                            creatures[target].setSecondAttr("HP", creatures[target].getSecondAttr("HP") - outcome.damage);
                        }
                        creatures[cycle].setSecondAttr("MP" ,creatures[cycle].getSecondAttr("MP") - nextAttack.MPCost);
                    
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

            int resistancePercent = 0;
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

            string defenceType = "";
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

                if (defender.getEquip("LeftArm") != null)
                {
                    if (defender.getEquip("LeftArm").getItemType() == "Shield")
                    {
                        chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr + defender.getEquip("LeftArm").getItemAttribute("Block")) * 100;
                        defenceType = "Block";
                    }
                    else
                    {
                        chance = attacker.getPrimaryAttr(attack.attributeOfAttack) * 100 / 2 / defenderAttr;
                    }
                }
                else
                {
                    Message.sendMessageDev(attacker.getPrimaryAttr(attack.attributeOfAttack) + " " + defenderAttr);
                    chance = attacker.getPrimaryAttr(attack.attributeOfAttack) * 100 / 2 / defenderAttr;
                }
            }
            else if (attack.type == "Range") //Ranged
            {
                int defenderAttr;
                defenderAttr = defender.getPrimaryAttr("Dex");
                defenceType = "Dodge";

                if (defender.getEquip("LeftArm").getItemType() == "Shield")
                {
                    chance = (attacker.getPrimaryAttr(attack.attributeOfAttack) / 2 / defenderAttr + defender.getEquip("LeftArm").getItemAttribute("Block")) * 100;
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

            Message.sendMessageDev(rand + " " + chance);
            System.Threading.Thread.Sleep(800);

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
