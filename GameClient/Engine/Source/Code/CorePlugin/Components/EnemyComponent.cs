using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using Duality.EditorHints;
using Engine.Constants;

namespace Engine
{

    [Serializable]
    public class EnemyComponent : Component, ICmpInitializable
    {
        private Enemy enemy;
        private EnemyType type;
        private List<NameOfAbility> abilities;
        private List<Ability> realAbilities;

        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public Stats Stats
        {
            get { return this.enemy.Stats; }
            set { this.enemy.Stats = value; }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Enemy Enemy
        {
            get { return this.enemy; }
            set { this.enemy = value; }
        }

        [EditorHintFlags(MemberFlags.ForceWriteback)]
        public List<NameOfAbility> AbilityNameStorage
        {
            get { return this.abilities; }
            set
            {
                this.abilities = value;
                if (value != null)
                {
                    List<Ability> temp = new List<Ability>();
                    for (int i = 0; i < this.abilities.Count; i++)
                    {
                        temp.Add((Ability)typeof(AbilityStorage).GetField(Enum.GetName(typeof(NameOfAbility), value[i])).GetValue(AbilityStorage.Punch));
                    }
                    Abilities = temp;
                }
                else
                {
                    Abilities = null;
                }
            }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public List<Ability> Abilities
        {
            get { return this.realAbilities; }
            set { this.realAbilities = value; }
        }

        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public EnemyType EnemyType
        {
            get { return this.type; }
            set
            {
                this.enemy = (Enemy)typeof(EnemyStorage).GetField(Enum.GetName(typeof(EnemyType), value)).GetValue(enemy);
                this.type = value;
            }
        }

        public EnemyComponent()
        {
            this.EnemyType = EnemyType.Wolf;
            this.AbilityNameStorage = new List<NameOfAbility>() { NameOfAbility.Claw };
        }

        void ICmpInitializable.OnInit(Component.InitContext context)
        {
            /*if (context == InitContext.Activate)
            {
                enemy.setLevel(lvl);
                enemy.setPrimaryAttr("Str", s);
                enemy.setPrimaryAttr("Dex", d);
                enemy.setPrimaryAttr("Vit", v);
                enemy.setPrimaryAttr("Int", i);
                for (int z = 0; z < abilities.Count; z++)
                {
                    enemy.addAbility(AbilityStorage.lookForAbility(Enum.GetName(typeof(Abilities), abilities[z])));
                }
            }*/
        }

        void ICmpInitializable.OnShutdown(Component.ShutdownContext context)
        {
            
        }
    }
}
