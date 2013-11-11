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
        public Ability nextAbility;
        public int nextTarget;

        public AI()
        {

        }

        //This method should se nextAbility and nextTarget accordingly
        public abstract void generateActionCombat(Creature user, Creature[] creatures, int myPlaceInCreature);

        //This method should be used to move the user through the World
        public abstract void moveWorld(Creature user);
    }

    public class defultAI : AI
    {
        public defultAI() : base()
        {
            
        }

        public override void generateActionCombat(Creature user, Creature[] creatures, int myPlaceInCreature)
        {
            //Defult Action code
            nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Length);
                if ((creatures[target].Stats.HP > 0) && (target != myPlaceInCreature) && (creatures[target].currentTeam != user.currentTeam))
                {
                    nextTarget = target;
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

        public override void generateActionCombat(Creature user, Creature[] creatures, int myPlaceInCreature)
        {
            //Defult Action code
            nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Length);
                if ((creatures[target].Stats.HP > 0) && (target != myPlaceInCreature) && (creatures[target].currentTeam != user.currentTeam))
                {
                    nextTarget = target;
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
