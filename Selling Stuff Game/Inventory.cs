using System.ComponentModel;

namespace Selling_Stuff_Game.Properties
{
    public class Inventory
    {
        public BindingList<Items> inventory;

        public Inventory(BindingList<Items> items)
        {
            this.inventory = items;
        }
    }
}
