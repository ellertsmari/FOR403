using Engine.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.CustomObjects
{
    public abstract class Item
    {
        protected Dictionary<string, int> itemAttributes = null;
        protected string equipSlot;

        public Item(string equipSlot)
        {
            string[] possibleSlots = new string[]
            {
                "Head",
                "Main-Hand",
                "Off-Hand",
                "Chest",
                "RightLeg",
                "LeftLeg"
            };

            bool exec = true;
            foreach (var slot in possibleSlots)
            {
                if (slot == equipSlot)
                {
                    exec = false;
                    break;
                }
            }
            if (exec)
            {
                throw new FORException("Slot in item does not exist");
            }
            else
            {
                this.equipSlot = equipSlot;
            }
        }

        public int getItemAttribute(string attribute)
        {
            return itemAttributes[attribute];
        }

        public string getEquipSlot()
        {
            return equipSlot;
        }
    }

    public class ItemShield : Item
    {
        int blockPercentage;

        public ItemShield(string equipSlot, int blockPercentage)
            : base(equipSlot)
        {
            this.blockPercentage = blockPercentage;
        }

        public int getBlock()
        {
            return blockPercentage;
        }
    }

    public class ItemWeapon : Item
    {
        private List<string> damageTypes = new List<string>();
        private int damage;
        private int critMod;


        public ItemWeapon(string equipSlot, int damage, int critMod) : base(equipSlot)
        {
            this.damageTypes.Add("Physical");
            this.damage = damage;
            this.critMod = critMod;
        }

        public int getDamage()
        {
            return damage;
        }

        public int getCritMod()
        {
            return critMod;
        }

        public List<string> getDamageType()
        {
            return damageTypes;
        }
    }
}
