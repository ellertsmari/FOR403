using Engine.Components;
using Engine.Constants;
using Engine.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Logic
{
    public abstract class AI
    {
        protected Ability nextAbility;
        protected int nextTarget;

        public Ability NextAbility
        {
            get { return this.nextAbility; }
        }

        public int NextTarget
        {
            get { return this.nextTarget; }
        }

        public AI()
        {

        }

        //This method should se nextAbility and nextTarget accordingly
        public abstract void generateActionCombat(Creature user, List<CreatureContainer> creatures);

        //This method should be used to move the user through the World
        public abstract void moveWorld(Creature user);
    }

    [Serializable]
    public class defultAI : AI
    {
        public defultAI() : base()
        {
            
        }

        public override void generateActionCombat(Creature user, List<CreatureContainer> creatures)
        {
            //Defult Action code
            this.nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Count);
                if ((creatures[target].Stats.HP > 0) && (!user.compareCreature(creatures[target].Creature)) && (creatures[target].Creature.currentTeam != user.currentTeam))
                {
                    this.nextTarget = target;
                    break;
                }
            }
        }

        public override void moveWorld(Creature user)
        {
            
        }
    }

    [Serializable]
    public class basicEnemyAI : AI
    {
        public basicEnemyAI() : base()
        {
            
        }

        public override void generateActionCombat(Creature user, List<CreatureContainer> creatures)
        {
            //Defult Action code
            this.nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Count);
                if ((creatures[target].Stats.HP > 0) && (!user.compareCreature(creatures[target].Creature)) && (creatures[target].Creature.currentTeam != user.currentTeam))
                {
                    this.nextTarget = target;
                    break;
                }
            }
        }

        public override void moveWorld(Creature user)
        {
            //something something
            user.position.x += 0;
            user.position.y += 0;
        }
    }
}
