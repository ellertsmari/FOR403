using Duality;
using Duality.ColorFormat;
using Duality.Components.Renderers;
using Engine.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Components
{
    public enum Frames
    {
        IDLEFRAME = 0 * CreatureContainer.FRAMENUMBER,
        MELEEFRAME = 1 * CreatureContainer.FRAMENUMBER,
        RANGEDFRAME = 2 * CreatureContainer.FRAMENUMBER,
        MAGICFRAME = 3 * CreatureContainer.FRAMENUMBER,
        SPECIALFRAME = 4 * CreatureContainer.FRAMENUMBER,
        DYINGFRAME = 5 * CreatureContainer.FRAMENUMBER
    }

    [Serializable]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    [RequiredComponent(typeof(TextRenderer))]
    public class CombatCreatureComponent : Component, ICmpUpdatable, ICmpInitializable
    {
        private int offset;

        private bool runSingle;

        public void offsetFrames(int offset)
        {
            this.offset = offset;
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

        public void setAnim(Frames FirstFrame)
        {
            runSingle = true;
            this.GameObj.GetComponent<AnimSpriteRenderer>().AnimTime = 0;
            this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame = ((int)FirstFrame + offset);
            this.GameObj.GetComponent<AnimSpriteRenderer>().AnimLoopMode = AnimSpriteRenderer.LoopMode.Once;
        }

        public void animateDamage(int damage)
        {
            this.GameObj.GetComponent<TextRenderer>().Text.SourceText = "" + damage;
        }

        public void setFirstFrame(Frames FirstFrame)
        {
            this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame = (int)FirstFrame + offset;
        }

        void ICmpUpdatable.OnUpdate()
        {
            if ((this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame == (int)Frames.DYINGFRAME + offset) && !this.GameObj.GetComponent<AnimSpriteRenderer>().IsAnimationRunning)
            {
                return;
            }

            if (!this.GameObj.GetComponent<AnimSpriteRenderer>().IsAnimationRunning&&runSingle)
            {
                runSingle = false;
                this.GameObj.GetComponent<TextRenderer>().Text.SourceText = "";
                this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame = (int)Frames.IDLEFRAME + offset;
                this.GameObj.GetComponent<AnimSpriteRenderer>().AnimLoopMode = AnimSpriteRenderer.LoopMode.Loop;
                Client.runningAnimation = false;
            }

            //if (this.GameObj.GetComponent<AnimSpriteRenderer>())

            /*if ((this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame == (int)Frames.MELEEFRAME + offset) || ((this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFirstFrame == (int)Frames.SPECIALFRAME + offset) && (this.Creature.ForwardOnSpecial)))
            {

                if (this.GameObj.GetComponent<AnimSpriteRenderer>().CurrentFrame <= this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFrameCount / 2)
                    this.GameObj.Transform.Pos = new OpenTK.Vector3(this.GameObj.Transform.Pos.X + this.GameObj.GetComponent<AnimSpriteRenderer>().CurrentFrame * 2 / this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFrameCount * CreatureContainer.MAXFORWARD, this.GameObj.Transform.Pos.Y, this.GameObj.Transform.Pos.Z);
                else
                {
                    this.GameObj.Transform.Pos = new OpenTK.Vector3(this.GameObj.Transform.Pos.X + CreatureContainer.MAXFORWARD - this.GameObj.GetComponent<AnimSpriteRenderer>().CurrentFrame * 2 / this.GameObj.GetComponent<AnimSpriteRenderer>().AnimFrameCount * CreatureContainer.MAXFORWARD, this.GameObj.Transform.Pos.Y, this.GameObj.Transform.Pos.Z);
                }
            }*/
        }

        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            if (context == InitContext.AddToGameObject)
            {
                this.GameObj.GetComponent<TextRenderer>().BlockAlign = Alignment.Top;
                this.GameObj.GetComponent<TextRenderer>().ColorTint = ColorRgba.Red;
            }
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }
    }
}
