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
                for (int i = 0; i < 3; i++)
                {
                    GameObject Obj = new GameObject();
                    Obj.AddComponent<Transform>();
                    Obj.AddComponent<SpriteRenderer>();
                    Obj.AddComponent(new SelectionListComponent(GameRes.Data.MenuTextures.PlayerMenu_Material, new Rect(0, 0, 117, 140), "Player Action", new OpenTK.Vector3(-26 + 117*i, 260, -1)));

                    Scene.Current.AddObject(Obj);

                    foreach (var item in Scene.Current.AllObjects.ToList())
                    {
                        if (item.Name == "PlayerMenuBackground")
                        {
                            Obj.Parent = item;
                            break;
                        }
                    }
                }

                foreach (var item in Scene.Current.AllObjects.ToList())
                {
                    if (item.Name == "PlayerMenuBackground")
                    {
                        foreach (var parent in item.Children.ToList())
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                GameObject TextObject = new GameObject();
                                TextObject.Parent = parent;

                                TextObject.AddComponent<Transform>();
                                TextObject.AddComponent<TextRenderer>();

                                TextObject.Transform.Pos = new OpenTK.Vector3(TextObject.Parent.Transform.Pos.X + TextObject.Parent.GetComponent<SpriteRenderer>().Rect.W / 2, TextObject.Parent.Transform.Pos.Y - TextObject.Parent.GetComponent<SpriteRenderer>().Rect.H*i/3, TextObject.Parent.Transform.Pos.Z-1);
                                TextObject.GetComponent<TextRenderer>().Text.SourceText = "Test " + i;
                                
                                Scene.Current.AddObject(TextObject);
                            }
                        }
                        break;
                    }
                }
                

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
