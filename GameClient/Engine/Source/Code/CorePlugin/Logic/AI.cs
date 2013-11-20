using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Resources;
using Engine.Components;
using Engine.Constants;
using Engine.CustomObjects;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Logic
{
    public abstract class AI
    {
        protected static bool waitingForInput = false;
        public static Ability abilityInput = null;
        public static int targetInput = -1;

        public static bool WaitingForInput
        {
            get { return waitingForInput; }
        }

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

        public void reset()
        {
            this.nextAbility = null;
            this.nextTarget = -1;
        }

        public AI()
        {

        }

        //This method should se nextAbility and nextTarget accordingly
        public abstract void generateActionCombat(Creature user, List<GameObject> creatures);

        //This method should be used to move the user through the World
        public abstract void moveWorld(Creature user);
    }

    [Serializable]
    public class defultAI : AI
    {
        public defultAI() : base()
        {
            
        }

        public override void generateActionCombat(Creature user, List<GameObject> creatures)
        {
            //Defult Action code
            this.nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Count);
                if ((creatures[target].GetComponent<CombatCreatureComponent>().Creature.Stats.HP > 0) && (!user.compareCreature(creatures[target].GetComponent<CombatCreatureComponent>().Creature.Creature)) && (creatures[target].GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam != user.currentTeam))
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

        public override void generateActionCombat(Creature user, List<GameObject> creatures)
        {
            //Defult Action code
            this.nextAbility = AbilityStorage.Punch;

            //Defult Targeting code
            while (true)
            {
                int target = ConstantLib.RANDOM.Next(creatures.Count);
                if ((creatures[target].GetComponent<CombatCreatureComponent>().Creature.Stats.HP > 0) && (!user.compareCreature(creatures[target].GetComponent<CombatCreatureComponent>().Creature.Creature)) && (creatures[target].GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam != user.currentTeam))
                {
                    this.nextTarget = target;
                    break;
                }
            }
        }

        public override void moveWorld(Creature user)
        {
            //something something
        }
    }

    [Serializable]
    public class playerAI : AI
    {
        private bool setup = false;

        public playerAI()
            : base()
        {

        }

        public override void generateActionCombat(Creature user, List<GameObject> creatures)
        {
            //SelectionList()
            if (!setup)
            {
                AI.waitingForInput = true;
                CombatList temp = new CombatList(new List<object>(user.abilities));
                temp.Add("Back");
                temp.Name = "Abilities";
                Client.OverlordObject.Children.ToList()[0].GetComponent<SelectionListComponent>().ListObjects = new List<object>()
                    {
                        temp,
                        "Ble",
                        "Bla"
                    };
                Client.OverlordObject.Children.ToList()[0].GetComponent<SelectionListComponent>().currentlySelected = true;

                setup = true;
            }

            if (AI.abilityInput != null && AI.targetInput != -1)
            {
                this.nextAbility = AI.abilityInput;
                this.nextTarget = AI.targetInput;

                foreach (var item in Client.OverlordObject.Children)
                {
                    item.GetComponent<SelectionListComponent>().cleanup();
                }
                AI.abilityInput = null;
                AI.targetInput = -1;
                AI.waitingForInput = false;
                setup = false;
            }
        }

        public override void moveWorld(Creature user)
        {

        }
    }
}
