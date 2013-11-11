using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    public class NPCComponent : Component, ICmpUpdatable
    {
        NPC npc;

        public NPCComponent(NPC npc)
        {
            this.npc = npc;
        }

        void ICmpUpdatable.OnUpdate()
        {
            
        }
    }
}
