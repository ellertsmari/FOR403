using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using Duality.EditorHints;
using Engine.Constants;
using Engine.CustomObjects;
using Engine.Logic;

namespace Engine.Components
{

    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    public class EnemyComponent : Component
    {
        private String groupName;
        private List<CreatureContainer> creatures;

        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public String Name
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        public List<CreatureContainer> Creatures
        {
            get { return this.creatures; }
            set { this.creatures = value; }
        }

        public EnemyComponent()
        {
            
        }
    }
}
