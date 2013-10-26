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
        public Creature user;
        public Creature target;

        public Result(Creature user, string result, Creature target)
        {
            this.result = result;
            this.user = user;
            this.target = target;
        }

        public override string ToString()
        {
            return result;
        }
    }

    //Here we make abilities
    class AbilityStorage
    {
        public static Dictionary<string, Ability> MELEE = new Dictionary<string, Ability>
                                {
                                    {"Punch", new AttackMelee("Punch", 0, 1, "Str")},
                                    {"Kick", new AttackMelee("Kick", 0, 2, "Str")}
                                };
        public static Dictionary<string, Ability> RANGE = new Dictionary<string, Ability>
                                {
                                };
        public static Dictionary<string, Ability> MAGIC = new Dictionary<string, Ability>
                                {
                                };
    }

    //Inherit this class to add new abilities to the game
    abstract class Ability
    {
        public string name;
        public int MPCost;
        public int MaxNumTargets;
        public string victimType;

        public Ability(string name, string victimType, int MPCost) : this(name, victimType, MPCost, 1) {}

        public Ability(string name, string victimType, int MPCost, int MaxNumTargets)
        {
            this.name = name;
            this.MPCost = MPCost;
            this.victimType = victimType;
            this.MaxNumTargets = MaxNumTargets;
        }

        //Here you code what the ability does
        public abstract Result runAbility(Creature user, Creature target);

        //Here you code the chance to hit
        public abstract int calculateChance(Creature user, Creature target);
    }

    //Class for basic melee attack abilities
    class AttackMelee : Ability
    {
        private float damageMod;
        private string damageType;
        private string attributeAttack;

        //Do not set, used in calculations
        private int defenderAttr;
        private string resultMessage;
        //END

        public AttackMelee(string name, int MPCost, float damageMod, string attributeAttack) : base(name, "Enemy", MPCost)
        {
            this.damageMod = damageMod;
            this.attributeAttack = attributeAttack;
            damageType = "Physical";
        }

        public AttackMelee(string name, int MPCost, float damageMod, string attributeAttack, string damageType) : this(name, MPCost, damageMod, attributeAttack)
        {
            this.damageType = damageType;
        }

        public override Result runAbility(Creature user, Creature target)
        {
            int chance = calculateChance(user, target);

            int hit = (ConstantLib.RANDOM.Next(100) + 1);

            if (!(chance < hit))
            {
                int damage;
                bool equipNull = false;

                if (user.getEquip("RightArm") == null)
                {
                    damage = 1;
                    equipNull = true;
                }
                else
                {
                    damage = ((ItemWeapon) user.getEquip("RightArm")).getDamage();
                }

                if (hit == 1)
                {
                    if (equipNull)
                    {
                        hit = 2;
                    }
                    else
                    {
                        hit = ((ItemWeapon)user.getEquip("RightArm")).getCritMod();
                    }
                }
                else
                {
                    hit = 1;
                }

                damage = (int)(damage * damageMod * hit + user.getSecondAttr("DamageModMelee"));
                if (user.getEquip("RightArm") != null)
                {
                    foreach (var item in ((ItemWeapon)user.getEquip("RightArm")).getDamageType())
                    {
                        if (target.getResistance().ContainsKey(item))
                        {
                            damage = damage * (100-target.getResistance()[item]) / 100;
                        }
                    }
                }

                if (damage < 1)
                {
                    resultMessage = "Immune";
                }
                else
                {
                    resultMessage = "Hit " + damage;
                    target.setSecondAttr("HP", target.getSecondAttr("HP") - damage);
                }
            }

            return new Result(user, resultMessage, target);
        }

        public override int calculateChance(Creature user, Creature target)
        {
            int chance;

            bool skip = true;
            if (target.getEquip("LeftArm") != null)
            {
                if (target.getEquip("LeftArm").getItemType() == "Shield")
                {
                    defenderAttr = target.getPrimaryAttr("Str") * (100 + ((ItemShield)target.getEquip("LeftArm")).getBlock()) / 100;
                    resultMessage = "Block";
                    skip = false;
                }
            }
            if (skip)
            {
                defenderAttr = target.getPrimaryAttr("Dex");
                resultMessage = "Dodge";
            }

            chance = user.getPrimaryAttr(this.attributeAttack) * 100 / 2 / defenderAttr;

            if (chance > 99)
            {
                chance = 99;
            }
            else if (chance < 1)
            {
                chance = 1;
            }

            return chance;
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
                Ability ability = creatures[cycle].generateAbility();
                int target = creatures[cycle].chooseTarget(creatures, cycle, ability);

                Result result = ability.runAbility(creatures[cycle], creatures[target]);
                creatures[cycle] = result.user;
                creatures[target] = result.target;
                Message.sendMessageDev(result.result);
                
                //Updates and checks for winner
                int won = this.update();
                if (won == 1)
                {
                    Message.sendMessageDev("Team 1 won");
                    checkReward();
                    return 1;
                }
                else if (won == 2)
                {
                    Message.sendMessageDev("Team 2 won");
                    checkReward();
                    return 2;
                }
                this.render();

                //Gets the next creature in the cycle
                cycle++;
                if (cycle == creatures.Length)
                {
                    cycle = 0;
                }

                //For console Test
                System.Threading.Thread.Sleep(800);
                Message.sendMessageDev("Health 1: " + creatures[0].getSecondAttr("HP") + " Health 2: " + creatures[1].getSecondAttr("HP"));
            }

            return 0;
        }

        //Determines order of attack by the dex variable of every creature in the args argument
        //COMPLETE
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

        //Checks for reward and gives it
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
                if (creature.getSecondAttr("HP") > 0)
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
