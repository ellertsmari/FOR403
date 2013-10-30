using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;
using Duality.Components.Physics;

using OpenTK;
using OpenTK.Input;

namespace Engine
{
    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    public class PlayerComponent : Component, ICmpUpdatable, ICmpInitializable
    {
        private GameClient.Player player;

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;

            if (DualityApp.Keyboard[Key.Left])
                body.ApplyLocalForce(Vector2.UnitX * -0.2f * body.Mass);
            else if (DualityApp.Keyboard[Key.Right])
                body.ApplyLocalForce(Vector2.UnitX * 0.2f * body.Mass);

            if (DualityApp.Keyboard[Key.Up])
                body.ApplyLocalForce(Vector2.UnitY * -0.2f * body.Mass);
            else if (DualityApp.Keyboard[Key.Down])
                body.ApplyLocalForce(Vector2.UnitY * 0.2f * body.Mass);

            if ((DualityApp.Keyboard.KeyReleased(Key.Down)||DualityApp.Keyboard.KeyReleased(Key.Up))&&(!(DualityApp.Keyboard.KeyPressed(Key.Down))||!(DualityApp.Keyboard.KeyPressed(Key.Up))))
            {
                body.LinearVelocity = new Vector2(body.LinearVelocity.X, 0);
            }

            if ((DualityApp.Keyboard.KeyReleased(Key.Right) || DualityApp.Keyboard.KeyReleased(Key.Left)) && (!(DualityApp.Keyboard.KeyPressed(Key.Right)) || !(DualityApp.Keyboard.KeyPressed(Key.Left))))
            {
                body.LinearVelocity = body.LinearVelocity = new Vector2(0, body.LinearVelocity.Y);
            }
        }
        
        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            player = new GameClient.Player("Player One");
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }
    }
}
