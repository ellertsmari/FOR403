using Duality;
using Duality.Components.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Components
{
    [Serializable]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    class CombatCreatureComponent : Component, ICmpUpdatable
    {
        public int IDLEFRAME = 0 * CreatureContainer.FRAMENUMBER;
        public int MELEEFRAME = 1 * CreatureContainer.FRAMENUMBER;
        public int RANGEDFRAME = 2 * CreatureContainer.FRAMENUMBER;
        public int MAGICFRAME = 3 * CreatureContainer.FRAMENUMBER;
        public int SPECIALFRAME = 4 * CreatureContainer.FRAMENUMBER;
        public int DYINGFRAME = 5 * CreatureContainer.FRAMENUMBER;

        public void offsetFrames(int offset)
        {
            IDLEFRAME += offset;
            MELEEFRAME += offset;
            RANGEDFRAME += offset;
            MAGICFRAME += offset;
            SPECIALFRAME += offset;
            DYINGFRAME += offset;
        }

        private CreatureContainer creature;

        public CreatureContainer Creature
        {
            get { return this.creature; }
            set { this.creature = value; }
        }

        public CombatCreatureComponent()
        {

        }

        public CombatCreatureComponent(CreatureContainer creature)
        {
            this.creature = creature;
        }

        void ICmpUpdatable.OnUpdate()
        {
            if ((this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame == this.MELEEFRAME) || ((this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame == this.SPECIALFRAME) && (this.Creature.ForwardOnSpecial)))
            {

                if (this.GameObj.GetComponent<AnimSpriteRenderer>().CurrentFrame <= this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFrameCount / 2)
                    this.GameObj.Transform.Pos = new OpenTK.Vector3(this.GameObj.Transform.Pos.X + this.GameObj.GetComponent<AnimSpriteRenderer>().CurrentFrame * 2 / this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFrameCount * CreatureContainer.MAXFORWARD, this.GameObj.Transform.Pos.Y, this.GameObj.Transform.Pos.Z);
                else
                {
                    this.GameObj.Transform.Pos = new OpenTK.Vector3(this.GameObj.Transform.Pos.X + CreatureContainer.MAXFORWARD - this.GameObj.GetComponent<AnimSpriteRenderer>().CurrentFrame * 2 / this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFrameCount * CreatureContainer.MAXFORWARD, this.GameObj.Transform.Pos.Y, this.GameObj.Transform.Pos.Z);
                }
            }
        }
    }
}
