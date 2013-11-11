using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Engine
{
    public class Result
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

    //Inherit this class to add new abilities to the game
    public abstract class Ability
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

        public override string ToString()
        {
            return this.name;
        }
    }

    //Class for basic melee attack abilities
    public class AttackMeleeBlunt : Ability
    {
        private float damageMod;
        private Dictionary<string, int> damageTypes = new Dictionary<string, int>();

        //Do not set, used in calculations
        private int defenderAttr;
        private string resultMessage;
        //END

        public AttackMeleeBlunt(string name, int MPCost, float damageMod) : base(name, "Enemy", MPCost)
        {
            this.damageMod = damageMod;
            this.damageTypes.Add("Physical", 100);
        }

        public AttackMeleeBlunt(string name, int MPCost, float damageMod, string[] damageTypes, int[] damageTypePercentage)
            : this(name, MPCost, damageMod)
        {
            if (damageTypes.Length != damageTypePercentage.Length)
            {
                throw new FORException("Length of arrays in method not the same");
            }
            for (int i = 0; i < damageTypes.Length; i++)
            {
                this.damageTypes.Add(damageTypes[i], damageTypePercentage[i]);
            }
        }

        public override Result runAbility(Creature user, Creature target)
        {
            int chance = calculateChance(user, target);

            int hit = (ConstantLib.RANDOM.Next(100) + 1);

            if (!(chance < hit))
            {
                int damage;
                bool equipNull = false;

                if (user.getEquip("Main-Hand") == null)
                {
                    damage = 1;
                    equipNull = true;
                }
                else
                {
                    damage = ((ItemWeapon)user.getEquip("Main-Hand")).getDamage();
                }

                if (hit == 1)
                {
                    if (equipNull)
                    {
                        hit = 2;
                    }
                    else
                    {
                        hit = ((ItemWeapon)user.getEquip("Main-Hand")).getCritMod();
                    }
                }
                else
                {
                    hit = 1;
                }

                damage = (int)(damage * damageMod + user.Stats.DamageModMelee) * hit;

                foreach (var item in this.damageTypes)
                {
                    if (target.getResistance().ContainsKey(item.Key))
                    {
                        damage -= damage * item.Value * target.getResistance()[item.Key] / 10000;
                    }
                }

                //Needs to figure out how to implement damage type on weapon into damage resistance
                /*if (user.getEquip("RightArm") != null)
                {
                    foreach (var item in ((ItemWeapon)user.getEquip("RightArm")).getDamageType())
                    {
                        if (target.getResistance().ContainsKey(item))
                        {
                            damage = damage * (100-target.getResistance()[item]) / 100;
                        }
                    }
                }*/

                if (damage < 1)
                {
                    resultMessage = "Immune";
                }
                else
                {
                    resultMessage = "Hit " + damage;
                    target.Stats.HP -= damage;
                }
            }

            return new Result(user, resultMessage, target);
        }

        public override int calculateChance(Creature user, Creature target)
        {
            int chance;

            bool skip = true;
            if (target.getEquip("Off-Hand") != null)
            {
                if (target.getEquip("Off-Hand").GetType() == typeof(ItemShield))
                {
                    defenderAttr = target.Stats.Strength * (100 + ((ItemShield)target.getEquip("Off-Hand")).getBlock()) / 100;
                    resultMessage = "Block";
                    skip = false;
                }
            }
            if (skip)
            {
                defenderAttr = target.Stats.Dexterity;
                resultMessage = "Dodge";
            }

            chance = user.Stats.Strength * 100 / 2 / defenderAttr;
            
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

    public class AttackMeleeSharp : Ability
    {
        private float damageMod;
        private Dictionary<string, int> damageTypes = new Dictionary<string, int>();

        //Do not set, used in calculations
        private int defenderAttr;
        private string resultMessage;
        //END

        public AttackMeleeSharp(string name, int MPCost, float damageMod)
            : base(name, "Enemy", MPCost)
        {
            this.damageMod = damageMod;
            this.damageTypes.Add("Physical", 100);
        }

        public AttackMeleeSharp(string name, int MPCost, float damageMod, string[] damageTypes, int[] damageTypePercentage)
            : this(name, MPCost, damageMod)
        {
            if (damageTypes.Length != damageTypePercentage.Length)
            {
                throw new FORException("Length of arrays in method not the same");
            }
            for (int i = 0; i < damageTypes.Length; i++)
            {
                this.damageTypes.Add(damageTypes[i], damageTypePercentage[i]);
            }
        }

        public override Result runAbility(Creature user, Creature target)
        {
            int chance = calculateChance(user, target);

            int hit = (ConstantLib.RANDOM.Next(100) + 1);

            if (!(chance < hit))
            {
                int damage;
                bool equipNull = false;

                if (user.getEquip("Main-Hand") == null)
                {
                    damage = 1;
                    equipNull = true;
                }
                else
                {
                    damage = ((ItemWeapon)user.getEquip("Main-Hand")).getDamage();
                }

                if (hit == 1)
                {
                    if (equipNull)
                    {
                        hit = 2;
                    }
                    else
                    {
                        hit = ((ItemWeapon)user.getEquip("Main-Hand")).getCritMod();
                    }
                }
                else
                {
                    hit = 1;
                }

                damage = (int)(damage * damageMod + user.Stats.DamageModMelee) * hit;

                foreach (var item in this.damageTypes)
                {
                    if (target.getResistance().ContainsKey(item.Key))
                    {
                        damage -= damage * item.Value * target.getResistance()[item.Key] / 10000;
                    }
                }

                //Needs to figure out how to implement damage type on weapon into damage resistance
                /*if (user.getEquip("RightArm") != null)
                {
                    foreach (var item in ((ItemWeapon)user.getEquip("RightArm")).getDamageType())
                    {
                        if (target.getResistance().ContainsKey(item))
                        {
                            damage = damage * (100-target.getResistance()[item]) / 100;
                        }
                    }
                }*/

                if (damage < 1)
                {
                    resultMessage = "Immune";
                }
                else
                {
                    resultMessage = "Hit " + damage;
                    target.Stats.HP -= damage;
                }
            }

            return new Result(user, resultMessage, target);
        }

        public override int calculateChance(Creature user, Creature target)
        {
            int chance;

            bool skip = true;
            if (target.getEquip("Off-Hand") != null)
            {
                if (target.getEquip("Off-Hand").GetType() == typeof(ItemShield))
                {
                    defenderAttr = target.Stats.Strength * (100 + ((ItemShield)target.getEquip("Off-Hand")).getBlock()) / 100;
                    resultMessage = "Block";
                    skip = false;
                }
            }
            if (skip)
            {
                defenderAttr = target.Stats.Dexterity;
                resultMessage = "Dodge";
            }

            chance = user.Stats.Dexterity * 100 / 2 / defenderAttr;

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

    public class Combat
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
                Ability ability;
                int target;
                creatures[cycle].generateAction(out ability, out target, creatures, cycle);

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
                Message.sendMessageDev("Health 1: " + creatures[0].Stats.HP + " Health 2: " + creatures[1].Stats.HP);
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
            Array.Sort(order, delegate(Creature x, Creature y) { return y.Stats.Dexterity.CompareTo(x.Stats.Dexterity); });
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
                    creature.Stats.Exp += rewardEXP;
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
                if (creature.Stats.HP > 0)
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
