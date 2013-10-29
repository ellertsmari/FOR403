using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;
using Duality.Components.Physics;

using OpenTK;
using OpenTK.Input;

using GameClient

namespace Engine
{
    [Serializable]
    [RequiredComponent(typeof(RigidBody))]
    public class PlayerComponent : Component, ICmpUpdatable
    {
        Player player;

        public PlayerComponent(Player player)
        {
            this.player = player;
            this.GameObj.RigidBody.Friction = 1;
        }

        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;

            if (DualityApp.Keyboard[Key.Left])
                body.ApplyLocalForce(Vector2.UnitX * -0.2f * body.Mass);
            else if (DualityApp.Keyboard[Key.Right])
                body.ApplyLocalForce(Vector2.UnitX * -0.2f * body.Mass);

            if (DualityApp.Keyboard[Key.Up])
                body.ApplyLocalForce(Vector2.UnitY * -0.2f * body.Mass);
            else if (DualityApp.Keyboard[Key.Down])
                body.ApplyLocalForce(Vector2.UnitY * 0.2f * body.Mass);
        }
    }
}
