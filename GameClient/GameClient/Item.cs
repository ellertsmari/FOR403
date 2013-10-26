using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClient
{
    abstract class Item
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

    class ItemShield : Item
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

    class ItemWeapon : Item
    {
        private List<string> damageTypes = new List<string>();

        public ItemWeapon(string equipSlot)
            : base(equipSlot)
        {
            this.damageTypes.Add("Physical");
        }

        public int getDamage()
        {
            return 1;
        }

        public int getCritMod()
        {
            return 2;
        }

        public List<string> getDamageType()
        {
            return damageTypes;
        }
    }
}
