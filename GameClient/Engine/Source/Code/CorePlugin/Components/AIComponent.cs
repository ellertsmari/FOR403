using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using System;

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
            get {  }
            set { this.ai = new defaultAi(); }
        }

        void ICmpUpdatable.OnUpdate()
        {
            ((EnemyComponent)this.GameObj.GetComponent(typeof(EnemyComponent))).Enemy.ai.
            RigidBody body = this.GameObj.RigidBody;
            //this.enemy.ai.moveWorld(this.enemy);
            //this.GameObj.Transform.Pos = new Vector3(this.enemy.position.x, this.enemy.position.y, this.GameObj.Transform.Pos.Z);
        }

        /*public void generateActionCombat(this, Creature[] creatures, int myPlaceInCreature)
        {

        }*/
    }
}
