using Duality;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using Duality.EditorHints;
using Duality.Resources;
using Engine.Constants;
using Engine.CustomObjects;
using Engine.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Components
{
    [Serializable]
    public class CreatureContainer
    {
        public static readonly int FRAMENUMBER = 8;
        public static readonly int MAXFORWARD = 50;

        private bool forwardOnSpecial;
        Creature creature;
        private List<NameOfAbility> abilities;
        private CreatureType type;
        private ContentRef<Material> combatSprite;
        private Rect combatRenderBox;
        //private ContentRef<Texture> prf = ContentProvider.RequestContent<Texture>(@"Data\MyShip");

        public bool ForwardOnSpecial
        {
            get { return this.forwardOnSpecial; }
            set { this.forwardOnSpecial = value; }
        }

        public CreatureContainer()
            : this(CreatureType.Wolf, NameOfAbility.Claw) {}

        public CreatureContainer(CreatureType type, params NameOfAbility[] abilities)
            : this (type, false, abilities) {}

        public CreatureContainer(CreatureType type, bool forwardOnSpecial, params NameOfAbility[] abilities)
            : this(type, forwardOnSpecial, null, abilities) {}

        public CreatureContainer(CreatureType type, bool forwardOnSpecial, ContentRef<Material> combatSprite, params NameOfAbility[] abilities)
        {
            this.CombatSprite = combatSprite;
            this.forwardOnSpecial = forwardOnSpecial;
            this.CreatureType = type;
            this.AbilityNameStorage = new List<NameOfAbility>(abilities);
        }

        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public ContentRef<Material> CombatSprite
        {
            get { return this.combatSprite; }
            set 
            {
                this.combatSprite = value;
                if (value == null) return;
                CombatSpriteRect = new Rect(-this.combatSprite.Res.MainTexture.Res.BasePixmap.Res.Atlas[0].W/2, -this.combatSprite.Res.MainTexture.Res.BasePixmap.Res.Atlas[0].H / 2, this.combatSprite.Res.MainTexture.Res.BasePixmap.Res.Atlas[0].W, this.combatSprite.Res.MainTexture.Res.BasePixmap.Res.Atlas[0].H);
            }
        }

        public Rect CombatSpriteRect
        {
            get { return this.combatRenderBox; }
            set { this.combatRenderBox = value; }
        }

        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public Stats Stats
        {
            get { return this.creature.Stats; }
            set { this.creature.Stats = value; }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Creature Creature
        {
            get { return this.creature; }
            set { this.creature = value; }
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
            get { return this.creature.abilities; }
            set { this.creature.abilities = value; }
        }

        [EditorHintFlags(MemberFlags.AffectsOthers)]
        public CreatureType CreatureType
        {
            get { return this.type; }
            set
            {
                this.creature = (Creature)typeof(CreatureStorage).GetField(Enum.GetName(typeof(CreatureType), value)).GetValue(creature);
                this.type = value;
            }
        }

        public override string ToString()
        {
            return this.CreatureType.ToString();
        }
    }
}
