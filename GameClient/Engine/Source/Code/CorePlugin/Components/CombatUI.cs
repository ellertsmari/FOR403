using Duality;
using Duality.Components.Renderers;
using Duality.Resources;
using Engine.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Components
{
    public interface CombatUI
    {

        string menuName();
    }

    public class CombatList : List<object>
    {
        private string name;
        private List<Ability> list;

        public CombatList(List<object> t) : base(t) { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }

    [Serializable]
    [RequiredComponent(typeof(SpriteRenderer))]
    [RequiredComponent(typeof(TextRenderer))]
    public class SelectionListComponent : Component, CombatUI, ICmpInitializable, ICmpUpdatable
    {
        private List<Object> listObjects;
        private int selected;
        private String name;
        private Rect rT;
        private ContentRef<Material> Background;
        OpenTK.Vector3 tempPos;
        public bool currentlySelected = false;
        private ContentRef<Material> contentRef;
        private Rect rect;
        private string p;
        private OpenTK.Vector3 vector3;
        private SelectionListComponent selectionListComponent;
        private int MenuNum;
        private int numOfMenues;
        private bool useCreatureList = false;
        private bool skipInput;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Object> ListObjects
        {
            get { return listObjects; }
            set { listObjects = value; }
        }

        public bool SkipInput
        {
            get { return skipInput; }
            set { skipInput = value; }
        }

        public SelectionListComponent(ContentRef<Material> background, string name, int menunumber, OpenTK.Vector3 pos)
            : this(background, new Rect(0, 0, 100, 80), name, menunumber, pos) {}

        public SelectionListComponent(ContentRef<Material> background, Rect rect, string name, int menunumber, OpenTK.Vector3 pos)
        {
            this.name = name;
            MenuNum = menunumber;
            Background = background;
            rT = rect;
            tempPos = pos;
            listObjects = new List<Object>();
            selected = 0;
        }

        string CombatUI.menuName()
        {
            return this.Name;
        }

        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            if (context == InitContext.AddToGameObject)
            {
                this.GameObj.GetComponent<SpriteRenderer>().Rect = rT;
                this.GameObj.GetComponent<SpriteRenderer>().SharedMaterial = Background;
                this.GameObj.Transform.Pos = tempPos;
            }
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }

        void ICmpUpdatable.OnUpdate()
        {
            if (this.currentlySelected && !this.SkipInput)
            {
                if (AI.WaitingForInput)
                {
                    if (DualityApp.Keyboard.KeyHit(OpenTK.Input.Key.Up))
                    {
                        if (selected == 0) return;

                        selected--;
                    }
                    else if (DualityApp.Keyboard.KeyHit(OpenTK.Input.Key.Down))
                    {
                        if (selected == ListObjects.Count - 1) return;

                        selected++;
                    }
                    else if (DualityApp.Keyboard.KeyHit(OpenTK.Input.Key.Enter))
                    {
                        this.currentlySelected = false;
                        if (this.listObjects[selected] is IList)
                        {
                            if (this.MenuNum < this.GameObj.Parent.ChildCount)
                            {
                                this.GameObj.Parent.Children.ToList()[MenuNum + 1].GetComponent<SelectionListComponent>().currentlySelected = true;
                                this.GameObj.Parent.Children.ToList()[MenuNum + 1].GetComponent<SelectionListComponent>().ListObjects = (List<Object>)listObjects[selected];
                                this.GameObj.Parent.Children.ToList()[MenuNum + 1].GetComponent<SelectionListComponent>().SkipInput = true;
                                this.GameObj.Parent.Children.ToList()[MenuNum + 1].GetComponent<SelectionListComponent>().selected = 0;
                            }
                        }
                        else if (this.listObjects[selected] is Ability)
                        {
                            AI.abilityInput = (Ability)listObjects[selected];
                            this.currentlySelected = true;

                            this.useCreatureList = true;
                        }
                        else if (this.listObjects[selected].ToString() == "Back")
                        {
                            if (this.MenuNum != 0)
                            {
                                this.GameObj.Parent.Children.ToList()[MenuNum - 1].GetComponent<SelectionListComponent>().currentlySelected = true;
                                this.listObjects = new List<object>();
                                this.GameObj.Parent.Children.ToList()[MenuNum - 1].GetComponent<SelectionListComponent>().SkipInput = true;
                            }
                        }
                        else if (this.useCreatureList)
                        {
                            AI.targetInput = selected;

                            this.GameObj.Parent.Children.ToList()[0].GetComponent<SelectionListComponent>().currentlySelected = true;
                        }
                        else
                        {
                            this.currentlySelected = true;
                        }
                    }
                }
            }

            for (int i = 0; i < this.GameObj.ChildCount; i++)
            {
                if (this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>() != null)
                {
                    if (this.useCreatureList)
                    {
                        if (AI.abilityInput.victimType == "Enemy")
                        {
                            if (Client.combat.Creatures[Client.combat.NextCreature].GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam == 1)
                            {
                                this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>().Text.SourceText = Client.Team2[selected + i - 1].GetComponent<CreatureContainer>().Creature.ToString();
                            }
                            else
                            {
                                this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>().Text.SourceText = Client.Team1[selected + i - 1].GetComponent<CreatureContainer>().Creature.ToString();
                            }
                        }
                        else if (AI.abilityInput.victimType == "Ally")
                        {
                            if (Client.combat.Creatures[Client.combat.NextCreature].GetComponent<CombatCreatureComponent>().Creature.Creature.currentTeam == 2)
                            {
                                this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>().Text.SourceText = Client.Team2[selected + i - 1].GetComponent<CreatureContainer>().Creature.ToString();
                            }
                            else
                            {
                                this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>().Text.SourceText = Client.Team1[selected + i - 1].GetComponent<CreatureContainer>().Creature.ToString();
                            }
                        }
                    }
                    else
                    {
                        if (!((selected + i - 1) < 0 || (selected + i - 1) > (this.ListObjects.Count - 1)))
                        {
                            this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>().Text.SourceText = this.ListObjects[selected + i - 1].ToString();
                        }
                        else
                        {
                            this.GameObj.Children.ToList()[i].GetComponent<TextRenderer>().Text.SourceText = "";
                        }
                    }
                }
            }

            this.SkipInput = false;
        }

        public void cleanup()
        {
            this.selected = 0;
            this.useCreatureList = false;
            this.listObjects = new List<object>();
            this.currentlySelected = false;
        }
    }

    [Serializable]
    [RequiredComponent(typeof(SpriteRenderer))]
    public class HealthUI : Component
    {

    }
}
