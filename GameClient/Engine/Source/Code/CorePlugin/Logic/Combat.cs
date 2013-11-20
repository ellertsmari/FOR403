using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Engine.CustomObjects;
using Engine.Constants;
using Engine.Components;
using Duality.Resources;
using Duality;

namespace Engine.Logic
{
    public class Result
    {
        public string result;
        public CreatureContainer user;
        public CreatureContainer target;

        public Result(CreatureContainer user, string result, CreatureContainer target)
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
        protected Frames animType;

        public Ability(string name, string victimType, int MPCost, Frames animType) : this(name, victimType, MPCost, 1, animType) { }

        public Ability(string name, string victimType, int MPCost, int MaxNumTargets, Frames animType)
        {
            this.name = name;
            this.MPCost = MPCost;
            this.victimType = victimType;
            this.MaxNumTargets = MaxNumTargets;
            this.animType = animType;
        }

        public Frames AnimType
        {
            get { return animType; }
        }

        //Here you code what the ability does
        public abstract Result runAbility(CreatureContainer user, CreatureContainer target);

        //Here you code the chance to hit
        public abstract int calculateChance(CreatureContainer user, CreatureContainer target);

        public override string ToString()
        {
            return this.name;
        }
    }

    //Class for basic melee attack abilities

    [Serializable]
    public class AttackMeleeBlunt : Ability
    {
        private float damageMod;
        private Dictionary<string, int> damageTypes = new Dictionary<string, int>();

        //Do not set, used in calculations
        private int defenderAttr;
        private string resultMessage;
        //END

        public AttackMeleeBlunt(string name, int MPCost, float damageMod) : base(name, "Enemy", MPCost, Frames.MELEEFRAME)
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

        public override Result runAbility(CreatureContainer user, CreatureContainer target)
        {
            int chance = calculateChance(user, target);

            int hit = (ConstantLib.RANDOM.Next(100) + 1);

            if (!(chance < hit))
            {
                int damage;
                bool equipNull = false;

                if (user.Creature.getEquip("Main-Hand") == null)
                {
                    damage = 1;
                    equipNull = true;
                }
                else
                {
                    damage = ((ItemWeapon)user.Creature.getEquip("Main-Hand")).getDamage();
                }

                if (hit == 1)
                {
                    if (equipNull)
                    {
                        hit = 2;
                    }
                    else
                    {
                        hit = ((ItemWeapon)user.Creature.getEquip("Main-Hand")).getCritMod();
                    }
                }
                else
                {
                    hit = 1;
                }

                damage = (int)(damage * damageMod + user.Stats.DamageModMelee) * hit;

                foreach (var item in this.damageTypes)
                {
                    if (target.Creature.getResistance().ContainsKey(item.Key))
                    {
                        damage -= damage * item.Value * target.Creature.getResistance()[item.Key] / 10000;
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

        public override int calculateChance(CreatureContainer user, CreatureContainer target)
        {
            int chance;

            bool skip = true;
            if (target.Creature.getEquip("Off-Hand") != null)
            {
                if (target.Creature.getEquip("Off-Hand").GetType() == typeof(ItemShield))
                {
                    defenderAttr = target.Stats.Strength * (100 + ((ItemShield)target.Creature.getEquip("Off-Hand")).getBlock()) / 100;
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

    [Serializable]
    public class AttackMeleeSharp : Ability
    {
        private float damageMod;
        private Dictionary<string, int> damageTypes = new Dictionary<string, int>();

        //Do not set, used in calculations
        private int defenderAttr;
        private string resultMessage;
        //END

        public AttackMeleeSharp(string name, int MPCost, float damageMod)
            : base(name, "Enemy", MPCost, Frames.MELEEFRAME)
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

        public override Result runAbility(CreatureContainer user, CreatureContainer target)
        {
            int chance = calculateChance(user, target);

            int hit = (ConstantLib.RANDOM.Next(100) + 1);

            if (!(chance < hit))
            {
                int damage;
                bool equipNull = false;

                if (user.Creature.getEquip("Main-Hand") == null)
                {
                    damage = 1;
                    equipNull = true;
                }
                else
                {
                    damage = ((ItemWeapon)user.Creature.getEquip("Main-Hand")).getDamage();
                }

                if (hit == 1)
                {
                    if (equipNull)
                    {
                        hit = 2;
                    }
                    else
                    {
                        hit = ((ItemWeapon)user.Creature.getEquip("Main-Hand")).getCritMod();
                    }
                }
                else
                {
                    hit = 1;
                }

                damage = (int)(damage * damageMod + user.Stats.DamageModMelee) * hit;

                foreach (var item in this.damageTypes)
                {
                    if (target.Creature.getResistance().ContainsKey(item.Key))
                    {
                        damage -= damage * item.Value * target.Creature.getResistance()[item.Key] / 10000;
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

        public override int calculateChance(CreatureContainer user, CreatureContainer target)
        {
            int chance;

            bool skip = true;
            if (target.Creature.getEquip("Off-Hand") != null)
            {
                if (target.Creature.getEquip("Off-Hand").GetType() == typeof(ItemShield))
                {
                    defenderAttr = target.Stats.Strength * (100 + ((ItemShield)target.Creature.getEquip("Off-Hand")).getBlock()) / 100;
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

    [Serializable]
    public class LoopComponent : Component, ICmpUpdatable
    {
        private Combat combat;
        private bool dispose = false;

        public Combat Combat
        {
            get { return this.combat; }
            set { this.combat = value; }
        }
        
        public LoopComponent(Combat combat)
        {
            this.Combat = combat;
        }

        void ICmpUpdatable.OnUpdate()
        {
            if (!Client.runningAnimation)
            {
                if (this.combat.Creatures[this.combat.NextCreature].GetComponent<CombatCreatureComponent>().Creature.combatAbility(this.combat.Creatures))
                {
                    if (dispose)
                    {
                        combat.runCombatCycle();
                        this.DisposeLater();
                    }
                    else if (combat.runCombatCycle() != 0)
                    {
                        dispose = true;
                    }
                }
                Client.combat = this.combat;
            }
        }
    }

    [Serializable]
    public class Combat
    {
        private List<GameObject> teamOne;
        private List<GameObject> teamTwo;
        private List<GameObject> creatures;
        private bool isReward;
        private int nextCreature = 0;
        private int winningTeam = 0;
        private int target = 0;

        public int NextCreature 
        {
            get { return this.nextCreature; }
            set { this.nextCreature = value; }
        }

        public List<GameObject> TeamOne
        {
            get { return this.teamOne; }
        }

        public List<GameObject> TeamTwo
        {
            get { return this.teamTwo; }
        }

        public List<GameObject> Creatures
        {
            get { return creatures; }
        }

        public Combat(List<GameObject> TeamOne, List<GameObject> TeamTwo) : this(TeamOne, TeamTwo, true) { }

        public Combat(List<GameObject> TeamOne, List<GameObject> TeamTwo, bool reward)
        {
            this.teamOne = TeamOne;
            this.teamTwo = TeamTwo;
            this.isReward = reward;
            initCombat();
        }

        //initializes combat, always run before runCombat
        private void initCombat()
        {
            foreach (var item in teamOne)
            {
                item.GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam = 1;
            }

            foreach (var item in teamTwo)
            {
                item.GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam = 2;
            }

            //Determine order of attack by Dex
            creatures = new List<GameObject>();
            creatures.AddRange(teamOne);
            creatures.AddRange(teamTwo);
            creatures = determineOrder(creatures);
        }

        public int runCombatCycle()
        {
            if (creatures[target].GetComponent<CombatCreatureComponent>().Creature.Stats.HP <= 0)
            {
                creatures[nextCreature].GetComponent<CombatCreatureComponent>().setAnim(Frames.DYINGFRAME);
                return 0;
            }

            if (winningTeam != 0) return winningTeam;

            Ability ability = creatures[nextCreature].GetComponent<CombatCreatureComponent>().Creature.nextAbility;
            target = creatures[nextCreature].GetComponent<CombatCreatureComponent>().Creature.nextTarget;

            creatures[nextCreature].GetComponent<CombatCreatureComponent>().Creature.nextAbility = null;
            creatures[nextCreature].GetComponent<CombatCreatureComponent>().Creature.nextTarget = -1;

            Result result = ability.runAbility(creatures[nextCreature].GetComponent<CombatCreatureComponent>().Creature, creatures[target].GetComponent<CombatCreatureComponent>().Creature);
            Client.runningAnimation = true;

            creatures[nextCreature].GetComponent<CombatCreatureComponent>().setAnim(ability.AnimType);

            creatures[nextCreature].GetComponent<CombatCreatureComponent>().Creature = result.user;
            creatures[target].GetComponent<CombatCreatureComponent>().Creature = result.target;
            Message.sendMessageDev(result.result);



            //Updates and checks for winner
            int won = this.update();
            if (won == 1)
            {
                winningTeam = 1;
                Message.sendMessageDev("Team 1 won");
                checkReward();
            }
            else if (won == 2)
            {
                winningTeam = 2;
                Message.sendMessageDev("Team 2 won");
                checkReward();
            }

            nextCreature++;
            if (NextCreature == creatures.Count) nextCreature = 0;

            return winningTeam;
        }

        /*//Starts the combat loop
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
                creatures[cycle].Creature.generateAction(out ability, out target, creatures);

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
                if (cycle == creatures.Count)
                {
                    cycle = 0;
                }

                //For console Test
                System.Threading.Thread.Sleep(800);
                Message.sendMessageDev("Health 1: " + creatures[0].Stats.HP + " Health 2: " + creatures[1].Stats.HP);
            }
            return 0;
        }*/

        //Determines order of attack by the dex variable of every creature in the args argument
        //COMPLETE
        private List<GameObject> determineOrder(params GameObject[] args)
        {
            return determineOrder(new List<GameObject>(args));
        }

        //Determines order of attack by the dex variable of every creature in the args argument
        //COMPLETE
        private List<GameObject> determineOrder(List<GameObject> args)
        {
            GameObject[] order = new GameObject[args.Count];
            int start = 0;
            foreach (var item in args)
            {
                order[start] = item;
                start++;
            }
            Array.Sort(order, delegate(GameObject x, GameObject y) { return y.GetComponent<CombatCreatureComponent>().Creature.Creature.Stats.Dexterity.CompareTo(x.GetComponent<CombatCreatureComponent>().Creature.Creature.Stats.Dexterity); });
            return new List<GameObject>(order);
        }

        //Checks for reward and gives it
        private void checkReward()
        {
            if (this.isReward)
            {
                /*List<CreatureContainer> give;
                List<CreatureContainer> take;
                Item[] rewardItems;
                int rewardGold = 0;
                int rewardEXP = 0;

                if (winningTeam == 1)
                {
                    give = this.teamOne;
                    take = this.teamTwo;
                }
                else
                {
                    give = this.teamTwo;
                    take = this.teamOne;
                }

                List<Item> list = new List<Item>();
                foreach (var creature in take)
                {
                    if (creature.Creature.reward != null)
                    {
                        foreach (var item in creature.Creature.reward)
                        {
                            list.Add(item.Value);
                        }
                    }
                    if (creature.Creature.rewardNum != null)
                    {
                        foreach (var item in creature.Creature.rewardNum)
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
                    if (creature.Creature is Player)
                    {
                        creature.Creature.inventory.addGold(rewardGold);
                        creature.Creature.inventory.openInvWindow(new Inventory(rewardItems.Length, rewardItems));
                    }
                }

                if (winningTeam == 1)
                {
                    this.teamOne = give;
                    this.teamTwo = take;
                }
                else
                {
                    this.teamTwo = give;
                    this.teamOne = take;
                }*/
            }
        }

        //Checks if battle is done or not
        private int update()
        {
            int t1 = 0;
            int t2 = 0;

            foreach (var creature in creatures)
            {
                if (creature.GetComponent<CombatCreatureComponent>().Creature.Creature.Stats.HP > 0)
                {
                    if (creature.GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam == 1)
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
    }
}
