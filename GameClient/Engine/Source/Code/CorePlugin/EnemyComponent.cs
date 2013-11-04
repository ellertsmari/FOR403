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
        Enemy enemy;

        public EnemyComponent(Enemy enemy)
        {
            this.enemy = enemy;
        }

        void ICmpUpdatable.OnUpdate()
        {
            this.enemy.ai.moveWorld(this.enemy);
            this.GameObj.Transform.Pos = new Vector3(this.enemy.position.x, this.enemy.position.y, this.GameObj.Transform.Pos.Z);
        }
    }
}
