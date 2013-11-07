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

    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    public class EnemyComponent : Component, ICmpUpdatable
    {
        /*public static void Create(Vector3 pos, Enemy type)
        {
            if (Player.Instance == null) return;
            type = Player.Instance.PickValidPowerup(type);

            if (type == PowerupType.FrontCannon)
                p = new GameObject(GameRes.Data.Prefabs.Powerups.FrontCannon_Prefab);
            else if (type == PowerupType.DiagonalCannon)
                p = new GameObject(GameRes.Data.Prefabs.Powerups.DiagonalCannon_Prefab);
            else if (type == PowerupType.SideCannon)
                p = new GameObject(GameRes.Data.Prefabs.Powerups.SideCannon_Prefab);
            else if (type == PowerupType.KillAll)
                p = new GameObject(GameRes.Data.Prefabs.Powerups.KillAll_Prefab);
            else
                return;

            p.Transform.Pos = pos;
            p.Transform.Vel = new Vector3(MathF.Rnd.NextVector2(1.0f));
            Scene.Current.RegisterObj(p);
        }*/

        private Enemy enemy;
        private EnemyType type;

        public EnemyType Enemy
        {
            get { return this.type; }
            set { enemy = (Enemy)typeof(ConstantLib).GetField(Enum.GetName(typeof(EnemyType), value)).GetValue(enemy); this.type = value; }
        }

        public int lvl;
        public int s;
        public int d;
        public int v;
        public int i;

        public int level{
            get { return this.lvl; }
            set { this.lvl = value; }
        }
        public int Str{
            get { return this.s; }
            set { this.s = value; }
        }
        public int Dex{
            get { return this.d; }
            set { this.d = value; }
        }
        public int Vit{
            get { return this.v; }
            set { this.v = value; }
        }
        public int Int{
            get { return this.i; }
            set { this.i = value; }
        }

        public EnemyComponent()
        {
            
        }

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;
            //this.enemy.ai.moveWorld(this.enemy);
            this.GameObj.Transform.Pos = new Vector3(this.enemy.position.x, this.enemy.position.y, this.GameObj.Transform.Pos.Z);
        }
    }
}
