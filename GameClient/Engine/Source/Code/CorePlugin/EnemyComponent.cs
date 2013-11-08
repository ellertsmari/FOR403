using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using GameClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace Engine
{
    public enum EnemyType
    {
        Skeleton,
        Zombie,
        GiantSpider,
        Wolf
    }

    public enum Abilities
    {
        Punch,
        Kick
    }

    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    public class EnemyComponent : Component, ICmpUpdatable, ICmpInitializable
    {
        public EnemyType EnemyType
        {
            get { return this.type; }
            set { enemy = (Enemy)typeof(ConstantLib).GetField(Enum.GetName(typeof(EnemyType), value)).GetValue(enemy); this.type = value; }
        }

        private Enemy enemy;
        private EnemyType type;
        private int lvl;
        private int s;
        private int d;
        private int v;
        private int i;
        private List<Abilities> abilities;

        

        /*public Enemy Enemy
        {
            get { return this.enemy; }
            private set { this.enemy = value; }
        }*/

        public int level{
            get { return this.lvl; }
            set { this.lvl = value; }
        }
        public int StatStr{
            get { return this.s; }
            set { this.s = value; }
        }
        public int StatDex
        {
            get { return this.d; }
            set { this.d = value; }
        }
        public int StatVit
        {
            get { return this.v; }
            set { this.v = value; }
        }
        public int StatInt
        {
            get { return this.i; }
            set { this.i = value; }
        }

        public List<Abilities> Abilities
        {
            get { return this.abilities; }
            set { this.abilities = value; }
        }

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;
            //this.enemy.ai.moveWorld(this.enemy);
            //this.GameObj.Transform.Pos = new Vector3(this.enemy.position.x, this.enemy.position.y, this.GameObj.Transform.Pos.Z);
        }

        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            /*if (context == InitContext.Activate)
            {
                enemy.setLevel(lvl);
                enemy.setPrimaryAttr("Str", s);
                enemy.setPrimaryAttr("Dex", d);
                enemy.setPrimaryAttr("Vit", v);
                enemy.setPrimaryAttr("Int", i);
                for (int z = 0; z < abilities.Count; z++)
                {
                    enemy.addAbility(AbilityStorage.lookForAbility(Enum.GetName(typeof(Abilities), abilities[z])));
                }
            }*/
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }
    }
}
