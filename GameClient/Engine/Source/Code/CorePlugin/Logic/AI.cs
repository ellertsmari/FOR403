using Engine.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
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
        public abstract void generateActionCombat(Creature user, Creature[] creatures);

        //This method should be used to move the user through the World
        public abstract void moveWorld(Creature user);
    }

    public class defultAI : AI
    {
        public defultAI() : base()
        {
            
        }

        public override void generateActionCombat(Creature user, Creature[] creatures)
        {
            //Defult Action code
            this.nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Length);
                if ((creatures[target].Stats.HP > 0) && (!user.compareCreature(creatures[target])) && (creatures[target].currentTeam != user.currentTeam))
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

    public class basicEnemyAI : AI
    {
        public basicEnemyAI() : base()
        {
            
        }

        public override void generateActionCombat(Creature user, Creature[] creatures)
        {
            //Defult Action code
            this.nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Length);
                if ((creatures[target].Stats.HP > 0) && (!user.compareCreature(creatures[target])) && (creatures[target].currentTeam != user.currentTeam))
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
