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
    public class TestObject : Component, ICmpUpdatable
    {
        void ICmpUpdatable.OnUpdate()
        {
            RigidBody body = this.GameObj.RigidBody;

            if (DualityApp.Keyboard[Key.Left])
                body.ApplyLocalForce(-0.0001f);
            else if (DualityApp.Keyboard[Key.Right])
                body.ApplyLocalForce(0.0001f);
            else
                body.AngularVelocity -= body.AngularVelocity * 0.1f * Time.TimeMult;

            if (DualityApp.Keyboard[Key.Up])
                body.ApplyLocalForce(Vector2.UnitY * -0.2f * body.Mass);
            else if (DualityApp.Keyboard[Key.Down])
                body.ApplyLocalForce(Vector2.UnitY * 0.2f * body.Mass);
        }
    }
}