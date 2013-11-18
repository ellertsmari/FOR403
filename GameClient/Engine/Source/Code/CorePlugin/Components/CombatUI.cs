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
    public class SelectableAbilityComponent : Component, CombatUI
    {
        private Ability ability;

        public Ability Ability
        {
            get { return ability; }
            set { ability = value; }
        }

        public SelectableAbilityComponent(Ability ability)
        {

        }

        string CombatUI.menuName()
        {
            return ability.ToString();
        }
    }

    [Serializable]
    [RequiredComponent(typeof(SpriteRenderer))]
    [RequiredComponent(typeof(TextRenderer))]
    public class SelectionListComponent : Component, CombatUI, ICmpInitializable
    {
        private List<GameObject> listObjects;
        private int selected;
        private String name;
        private Rect rT;
        private ContentRef<Material> Background;
        OpenTK.Vector3 tempPos;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<GameObject> ListObjects
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
            listObjects = new List<GameObject>();
        }

        //This used to make a double list
        public SelectionListComponent(ContentRef<Material> background, Rect rect, string name, OpenTK.Vector3 pos, params SelectionListComponent[] args)
            : this(background, rect, name, pos)
        {
            foreach (var item in args)
            {
                GameObject obj = new GameObject();
                obj.AddComponent<Transform>();
                obj.AddComponent<SpriteRenderer>();
                obj.AddComponent<TextRenderer>();
                obj.AddComponent(item);
                obj.Active = false;

                listObjects.Add(obj);
            }
        }

        //This used for SelectableAbilityComponent list
        public SelectionListComponent(ContentRef<Material> background, Rect rect, string name, OpenTK.Vector3 pos, params Ability[] args)
            : this(background, rect, name, pos)
        {
            foreach (var item in args)
            {
                GameObject obj = new GameObject();
                obj.AddComponent<Transform>();
                obj.AddComponent<SpriteRenderer>();
                obj.AddComponent<TextRenderer>();
                obj.AddComponent(new SelectableAbilityComponent(item));
                obj.Transform.Pos = new OpenTK.Vector3(pos.Xy, pos.Z - 1);
                obj.Active = false;

                listObjects.Add(obj);
            }
        }

        public void listObjectPos(int x, int y, int z)
        {
            foreach (var item in listObjects)
            {
                if (item.Transform != null)
                {
                    item.Transform.Pos = new OpenTK.Vector3(x, y, z);
                }
            }
        }

        public void listObjectRect(Rect rect)
        {
            foreach (var item in listObjects)
            {
                if (item.GetComponent<SpriteRenderer>() != null)
                {
                    item.GetComponent<SpriteRenderer>().Rect = rect;
                }
            }
        }

        public void select(int selected)
        {
            this.selected = selected;
            for (int i = 0; i < this.listObjects.Count; i++)
            {
                if (i == selected)
                {
                    listObjects[i].Active = true;
                }
                else
                {
                    listObjects[i].Active = false;
                }
            }
        }

        public void addAllListObjects(Scene scene)
        {
            scene.AddObject(this.GameObj);
            if (listObjects == null) return;
            foreach (var item in listObjects)
            {
                if (item.GetComponent<SelectionListComponent>() != null)
                {
                    item.GetComponent<SelectionListComponent>().addAllListObjects(scene);
                }
                else
                {
                    scene.AddObject(ListObjects);
                }
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
    }
}
