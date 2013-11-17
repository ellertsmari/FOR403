using Duality;
using Duality.Components.Renderers;
using Duality.EditorHints;
using Engine.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Components
{
    [Serializable]
    public class ResolutionUpdateComponent : Component, ICmpUpdatable, ICmpInitializable
    {
        private float resWidth = 0;
        private float resHeight = 0;

        private Rect startingRect;
        private float resNormalWidth;
        private float resNormalHeight;
        private float scale = 1;

        private bool fullWindow = true;

        public bool FullWindow
        {
            get { return this.fullWindow; }
            set { this.fullWindow = value; }
        }

        public float ResNormalWidth
        {
            get { return this.resNormalWidth; }
            set { this.resNormalWidth = value; }
        }

        public float ResNormalHeight
        {
            get { return this.resNormalHeight; }
            set { this.resNormalHeight = value; }
        }

        public float Scale
        {
            get { return this.scale; }
            set { this.scale = value; }
        }

        public ResolutionUpdateComponent()
        {
            
        }

        void ICmpUpdatable.OnUpdate()
        {
            if (resWidth == DualityApp.TargetResolution.X && resHeight == DualityApp.TargetResolution.Y) return;
            resWidth = DualityApp.TargetResolution.X;
            resHeight = DualityApp.TargetResolution.Y;
            Rect resizeRect;

            if (fullWindow)
            {
                resizeRect = new Rect(-(resWidth / 2), -(resHeight / 2), resWidth, resHeight);
            }
            else
            {
                resizeRect = new Rect(startingRect.X * resWidth * Scale / ResNormalWidth, startingRect.Y * resHeight * Scale / ResNormalHeight, startingRect.W * resWidth * Scale / ResNormalWidth, startingRect.H * resHeight * Scale / ResNormalHeight);
            }
            if (this.GameObj.GetComponent<SpriteRenderer>() != null)
            {
                this.GameObj.GetComponent<SpriteRenderer>().Rect = resizeRect;
            }
            else if (this.GameObj.GetComponent<AnimSpriteRenderer>() != null)
            {
                this.GameObj.GetComponent<AnimSpriteRenderer>().Rect = resizeRect;
            }
            else
            {
                throw new FORException("No renderer present on following GameObject: " + this.GameObj);
            }
        }

        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            if (context.HasFlag(InitContext.Loaded))
            {
                ResNormalWidth = DualityApp.UserData.GfxWidth;
                ResNormalHeight = DualityApp.UserData.GfxHeight;

                if (this.GameObj.GetComponent<SpriteRenderer>() != null)
                {
                    startingRect = this.GameObj.GetComponent<SpriteRenderer>().Rect;
                }
                else if (this.GameObj.GetComponent<AnimSpriteRenderer>() != null)
                {
                    startingRect = this.GameObj.GetComponent<AnimSpriteRenderer>().Rect;
                }
                else
                {
                    throw new FORException("This has to be added after a renderer");
                }
            }
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }
    }
}
