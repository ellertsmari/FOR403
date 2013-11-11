using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Constants
{
    public enum NameOfAbility
    {
        Punch,
        Kick,
        Claw,
        Swipe
    }

    public class AbilityStorage
    {
        public static readonly Ability Punch = new AttackMeleeBlunt("Punch", 0, 1);
        public static readonly Ability Kick = new AttackMeleeBlunt("Kick", 0, 2);
        public static readonly Ability Claw = new AttackMeleeSharp("Claw", 0, 1);
        public static readonly Ability Swipe = new AttackMeleeSharp("Swipe", 0, 2);
    }
}
