using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using Engine.CustomObjects;
using Engine.Logic;
using System;
using System.Collections.Generic;

namespace Engine.Components
{
    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    [RequiredComponent(typeof(EnemyComponent))]
    class AIComponent : Component, ICmpUpdatable
    {
        private AI ai;

        public AIComponent()
        {
            
        }

        public AI AI
        {
            get { return this.ai; }
            set { this.ai = new defultAI(); }
        }

        void ICmpUpdatable.OnUpdate()
        {
            //this.enemy.ai.moveWorld(this.enemy);
            //this.GameObj.Transform.Pos = new Vector3(this.enemy.position.x, this.enemy.position.y, this.GameObj.Transform.Pos.Z);
        }

        public void generateActionCombat(Creature user, List<CreatureContainer> creatures)
        {
            this.AI.generateActionCombat(user, creatures);
        }
    }
}
