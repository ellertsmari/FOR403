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
    public class PlayerComponent : Component, ICmpUpdatable
    {
        private GameClient.Player player;

        public PlayerComponent()
        {
            player = new GameClient.Player("Player One");
            Console.Out.WriteLine("Stop");

        }

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;
            AnimSpriteRenderer sprite = this.GameObj.GetComponent<AnimSpriteRenderer>();
            int maxSpeed = player.getSecondAttr("Speed");

            if (DualityApp.Keyboard[Key.Left] && DualityApp.Keyboard[Key.Up])
            {
                body.LinearVelocity = new Vector2((float)(maxSpeed * Math.Cos(Math.PI * 5 / 4)), (float)(maxSpeed * Math.Sin(Math.PI * 5 / 4)));
                sprite.AnimFirstFrame = 0;
                sprite.AnimPaused = false;
            }
            else if (DualityApp.Keyboard[Key.Left] && DualityApp.Keyboard[Key.Down])
            {
                body.LinearVelocity = new Vector2((float)(maxSpeed * Math.Cos(Math.PI * 3 / 4)), (float)(maxSpeed * Math.Sin(Math.PI * 3 / 4)));
                sprite.AnimFirstFrame = 0;
                sprite.AnimPaused = false;
            }
            else if (DualityApp.Keyboard[Key.Right] && DualityApp.Keyboard[Key.Up])
            {
                body.LinearVelocity = new Vector2((float)(maxSpeed * Math.Cos(Math.PI * 7 / 4)), (float)(maxSpeed * Math.Sin(Math.PI * 7 / 4)));
                sprite.AnimFirstFrame = 0;
                sprite.AnimPaused = false;
            }
            else if (DualityApp.Keyboard[Key.Right] && DualityApp.Keyboard[Key.Down])
            {
                body.LinearVelocity = new Vector2((float)(maxSpeed * Math.Cos(Math.PI / 4)), (float)(maxSpeed * Math.Sin(Math.PI / 4)));
                sprite.AnimFirstFrame = 0;
                sprite.AnimPaused = false;
            }
            else
            {
                if (DualityApp.Keyboard[Key.Left])
                {
                    body.LinearVelocity = new Vector2(-maxSpeed, 0);
                    sprite.AnimFirstFrame = 0;
                    sprite.AnimPaused = false;
                }
                else if (DualityApp.Keyboard[Key.Right])
                {
                    body.LinearVelocity = new Vector2(maxSpeed, 0);
                    sprite.AnimFirstFrame = 8;
                    sprite.AnimPaused = false;
                }

                if (DualityApp.Keyboard[Key.Up])
                {
                    body.LinearVelocity = new Vector2(0, -maxSpeed);
                    sprite.AnimFirstFrame = 16;
                    sprite.AnimPaused = false;
                }
                else if (DualityApp.Keyboard[Key.Down])
                {
                    body.LinearVelocity = new Vector2(0, maxSpeed);
                    sprite.AnimFirstFrame = 24;
                    sprite.AnimPaused = false;
                }
            }
            
            if ((DualityApp.Keyboard.KeyReleased(Key.Down)||DualityApp.Keyboard.KeyReleased(Key.Up))&&(!(DualityApp.Keyboard.KeyPressed(Key.Down))||!(DualityApp.Keyboard.KeyPressed(Key.Up))))
            {
                body.LinearVelocity = new Vector2(body.LinearVelocity.X, 0);
                sprite.AnimTime = 0;
                sprite.AnimPaused = true;
            }

            if ((DualityApp.Keyboard.KeyReleased(Key.Right) || DualityApp.Keyboard.KeyReleased(Key.Left)) && (!(DualityApp.Keyboard.KeyPressed(Key.Right)) || !(DualityApp.Keyboard.KeyPressed(Key.Left))))
            {
                body.LinearVelocity = body.LinearVelocity = new Vector2(0, body.LinearVelocity.Y);
                sprite.AnimTime = 0;
                sprite.AnimPaused = true;
            }
        }
    }
}
