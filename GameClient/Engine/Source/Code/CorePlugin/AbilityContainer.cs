using Duality;
using GameClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public enum NameOfAbility
    {
        Punch,
        Kick
    }
    
    [Serializable]
    public class AbilityContainer : Resource
    {
        private NameOfAbility _name;
        public static readonly Enemy Skeleton = new Enemy("Skeleton", 11, 13, 3, 8);

        public AbilityContainer()
        {

        }

        [NonSerialized]
        private Ability _ability;

        public NameOfAbility NameOfAbility
        {
            get { return this._name; }
            set { this._name = value; this._ability = lookForAbility(Enum.GetName(typeof(NameOfAbility), value)); }
        }

        public Ability getAbility()
        {
            return this._ability;
        }

        private Ability lookForAbility(String name)
        {
            if (AbilityStorage.MELEE.ContainsKey(name))
            {
                return AbilityStorage.MELEE[name];
            }
            else if (AbilityStorage.RANGE.ContainsKey(name))
            {
                return AbilityStorage.MELEE[name];
            }
            else if (AbilityStorage.MAGIC.ContainsKey(name))
            {
                return AbilityStorage.MELEE[name];
            }
            else
            {
                return null;
            }
        }
    }
}
