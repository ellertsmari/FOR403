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
    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    public class EnemyComponent : Component, ICmpUpdatable
    {
        public static void Create(Vector3 pos, Enemy type)
        {
            GameObject p;

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
        }

        private Enemy enemy;

        public Enemy EnemyType
        {
            get { return this.enemy; }
            set { this.enemy = value; }
        }

        public EnemyComponent()
        {
            
        }

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;
            this.enemy.ai.moveWorld(this.enemy);
            this.GameObj.Transform.Pos = new Vector3(this.enemy.position.x, this.enemy.position.y, this.GameObj.Transform.Pos.Z);
        }
    }
}
