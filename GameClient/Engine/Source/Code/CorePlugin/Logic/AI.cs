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

        public override void generateActionCombat(Creature user, List<CreatureContainer> creatures)
        {
            //SelectionList()
            if (!setup)
            {
                GameObject Object1 = new GameObject();
                Object1.AddComponent<Transform>();
                Object1.AddComponent<SpriteRenderer>();
                Object1.AddComponent(new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(-26, 260, -1), new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(91, 260, -3))));

                Object1.GetComponent<SelectionListComponent>().addAllListObjects(Scene.Current);

                GameObject Object2 = new GameObject();
                Object2.AddComponent<Transform>();
                Object2.AddComponent<SpriteRenderer>();
                Object2.AddComponent(new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(91, 260, -1), new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(91, 260, -3))));

                Object2.GetComponent<SelectionListComponent>().addAllListObjects(Scene.Current);

                GameObject Object3 = new GameObject();
                Object3.AddComponent<Transform>();
                Object3.AddComponent<SpriteRenderer>();
                Object3.AddComponent(new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(208, 260, -1), new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(91, 260, -3))));

                foreach (var item in Scene.Current.AllObjects.ToList())
                {
                    if (item.Name == "PlayerMenuBackground")
                    {
                        Object1.Parent = item;
                        Object2.Parent = item;
                        Object3.Parent = item;
                        break;
                    }
                }

                Object3.GetComponent<SelectionListComponent>().addAllListObjects(Scene.Current);

                setup = true;
            }

            if (DualityApp.Mouse.ButtonPressed(MouseButton.Left))
            {
                if (DualityApp.Mouse.X == 0)
                {

                }
            }

            if (DualityApp.Keyboard[Key.Up])
            {

            }
            else if (DualityApp.Keyboard[Key.Down])
            {

            }
            else if (DualityApp.Keyboard[Key.Enter])
            {

            }
        }

        public override void moveWorld(Creature user)
        {

        }
    }
}
