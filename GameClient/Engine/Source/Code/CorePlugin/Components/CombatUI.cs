using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Resources;
using Engine.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Components
{
    public interface CombatUI
    {

        string menuName();
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

        public SelectionListComponent(ContentRef<Material> background, string name, OpenTK.Vector3 pos)
            : this(background, new Rect(0, 0, 100, 80), name, pos) {}

        public SelectionListComponent(ContentRef<Material> background, Rect rect, string name, OpenTK.Vector3 pos)
        {
            this.name = name;
            Background = background;
            rT = rect;
            tempPos = pos;
            listObjects = new List<Object>();
        }

        public void select(int selected)
        {
            this.selected = selected;
            for (int i = 0; i < this.listObjects.Count; i++)
            {
                
            }
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
            if (currentlySelected)
            {
                if (DualityApp.Keyboard.KeyPressed(OpenTK.Input.Key.Up))
                {
                    if (selected == 0) return;

                    selected++;
                    
                }
                else if (DualityApp.Keyboard.KeyPressed(OpenTK.Input.Key.Down))
                {
                    if (selected == ListObjects.Count - 1) return;

                    selected++;
                }
                else if (DualityApp.Keyboard.KeyPressed(OpenTK.Input.Key.Enter))
                {
                    this.currentlySelected = false;

                }
            }
        }
    }
}
