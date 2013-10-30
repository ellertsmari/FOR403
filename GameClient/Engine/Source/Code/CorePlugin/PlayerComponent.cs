using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;
using Duality.Components.Physics;

using OpenTK;
using OpenTK.Input;
using Duality.Components.Renderers;

namespace Engine
{
    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    [RequiredComponent(typeof(AnimSpriteRenderer))]
    public class PlayerComponent : Component, ICmpUpdatable, ICmpInitializable
    {
        private GameClient.Player player;

        public PlayerComponent()
        {
            player = new GameClient.Player("Player One");
        }

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;
            AnimSpriteRenderer sprite = this.GameObj.GetComponent<AnimSpriteRenderer>();

            if (DualityApp.Keyboard[Key.Left])
            {
                body.ApplyLocalForce(Vector2.UnitX * 0.01f * player.getSecondAttr("Speed") * body.Mass);
                sprite.AnimFirstFrame = 0;
                sprite.AnimPaused = false;
            }
            else if (DualityApp.Keyboard[Key.Right])
            {
                body.ApplyLocalForce(Vector2.UnitX * 0.01f * player.getSecondAttr("Speed") * body.Mass);
                sprite.AnimFirstFrame = 8;
                sprite.AnimPaused = false;
            }

            if (DualityApp.Keyboard[Key.Up])
            {
                body.ApplyLocalForce(Vector2.UnitX * 0.01f * player.getSecondAttr("Speed") * body.Mass);
                sprite.AnimFirstFrame = 16;
                sprite.AnimPaused = false;
            }
            else if (DualityApp.Keyboard[Key.Down])
            {
                body.ApplyLocalForce(Vector2.UnitX * 0.01f * player.getSecondAttr("Speed") * body.Mass);
                sprite.AnimFirstFrame = 24;
                sprite.AnimPaused = false;
            }

            if ((DualityApp.Keyboard.KeyReleased(Key.Down)||DualityApp.Keyboard.KeyReleased(Key.Up))&&(!(DualityApp.Keyboard.KeyPressed(Key.Down))||!(DualityApp.Keyboard.KeyPressed(Key.Up))))
            {
                body.LinearVelocity = new Vector2(body.LinearVelocity.X, 0);
                if (DualityApp.Keyboard.KeyReleased(Key.Up))
                {
                    sprite.AnimFirstFrame = 16;
                    sprite.AnimPaused = true;
                }
                else if (DualityApp.Keyboard.KeyReleased(Key.Down))
                {
                    sprite.AnimFirstFrame = 24;
                    sprite.AnimPaused = true;
                }
            }

            if ((DualityApp.Keyboard.KeyReleased(Key.Right) || DualityApp.Keyboard.KeyReleased(Key.Left)) && (!(DualityApp.Keyboard.KeyPressed(Key.Right)) || !(DualityApp.Keyboard.KeyPressed(Key.Left))))
            {
                body.LinearVelocity = body.LinearVelocity = new Vector2(0, body.LinearVelocity.Y);
                if (DualityApp.Keyboard.KeyReleased(Key.Left))
                {
                    sprite.AnimFirstFrame = 0;
                    sprite.AnimPaused = true;
                }
                else if (DualityApp.Keyboard.KeyReleased(Key.Right))
                {
                    sprite.AnimFirstFrame = 8;
                    sprite.AnimPaused = true;
                }
            }
        }
        
        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }
    }
}
