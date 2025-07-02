using Selling_Stuff_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selling_Stuff_Game
{
    public partial class MainScreen : Form
    {
        #region Lists and Variables

        CharacterStats stats;
        public static List<CharacterStats> characterStats;
        public static Inventory Inventory;

        #endregion
        #region Main Constructor

        public MainScreen()
        {
            InitializeComponent();
            characterStats = Utility.LoadData1();
            Inventory = new Inventory(Utility.LoadData2());
            InventoryData.DataSource = Inventory.inventory;
            StartUp();
        }

        #endregion
        #region Button Clicks

        private void Extras_Click(object sender, EventArgs e)
        {
            Extras extras = new Extras();
            extras.Show();
            this.Hide();
        }
        private async void Eat_Click(object sender, EventArgs e)
        {
            Search.Enabled = false;
            Eat.Enabled = false;
            EatFood();
            await EnableButtons(1);
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private async void Search_Click(object sender, EventArgs e)
        {
            Search.Enabled = false;
            Eat.Enabled = false;
            SearchTrash();
            await EnableButtons(1);
            SellAll.Enabled = true;
            SellOne.Enabled = true;
        }
        private void SellAll_Click(object sender, EventArgs e)
        {
            SellAllItems();
        }
        private void SellOne_Click(object sender, EventArgs e)
        {
            SellOneItem();
        }
        private void LevelUp_Click(object sender, EventArgs e)
        {
            if (stats.level == 0 && stats.money >= 100)
            {
                stats.level += 1;
                stats.money -= 90;
                DumpsterBox.Text = "Rusty Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 1 && stats.money >= 300)
            {
                stats.level += 1;
                stats.money -= 200;
                DumpsterBox.Text = "Old Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 2 && stats.money >= 600)
            {
                stats.level += 1;
                stats.money -= 500;
                DumpsterBox.Text = "Mid Tier Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 3 && stats.money >= 1000)
            {
                stats.level += 1;
                stats.money -= 900;
                DumpsterBox.Text = "High Class Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 4 && stats.money >= 1500)
            {
                stats.level += 1;
                stats.money -= 1400;
                DumpsterBox.Text = "Luxury Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 5 && stats.money >= 2100)
            {
                stats.level += 1;
                stats.money -= 2000;
                DumpsterBox.Text = "Gold Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 6 && stats.money >= 2800)
            {
                stats.level += 1;
                stats.money -= 2700;
                DumpsterBox.Text = "Diamond Dumpster";
                Utility.SaveStats(characterStats);
                StartUp();
            }
            else if (stats.level == 7)
            {
                MessageBox.Show("You have reached the max level, you cannot level up anymore.");
            }
            else
            {
                MessageBox.Show("You do not have enough m oney to level up.");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Utility.SaveStats(characterStats);
            Utility.SaveItems(Inventory.inventory);
            MessageBox.Show("Your game has been saved.");
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
        #region Events and Methods

        private void InventoryData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            InventoryData.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
        }
        async Task EnableButtons(int seconds)
        {
            await Task.Delay(1000 * seconds);
            Search.Enabled = true;
            Eat.Enabled = true;
        }
        private void StartUp()
        {
            stats = Utility.GetNewestData();
            Health.Text = $"Health 100 / {stats.health}";
            Money.Text = $"Money ${stats.money}";
            LevelPopUp();
            CheckHealth();
            if (!Inventory.inventory.Any())
            {
                SellAll.Enabled = false;
                SellOne.Enabled = false;
            }
        }
        private void EatFood()
        {
            Random random = new Random();
            int chance = random.Next(1, 101);

            if (chance <= 20)
            {
                MessageBox.Show("You ate a moldy Zebra Cake, you have lost 20 health");
                Remove20Health();
            }
            else if (chance > 20 && chance < 40)
            {
                MessageBox.Show("You ate a Zebra Cake, you have gained 10 health");
                Add10Health();
            }
            else if (chance > 40 && chance <= 80)
            {
                MessageBox.Show("You ate a Zebra Cake, but it was stale. No health gained or lost.");
            }
            else if (chance > 80 && chance <= 92)
            {
                MessageBox.Show("You fell into the dumpster and ate dumpster slime");

            }
            else if (chance > 92 && chance <= 97)
            {
                MessageBox.Show("You ate raw beef and gained the knowlage to spawn 10 dollars");
                Add10();
            }
            else if (chance > 97 && chance <= 99)
            {
                MessageBox.Show("You automatically leveled up to the next dumpster");
                InstaLevelUp();
            }
            else if (chance > 99 && chance <= 100)
            {
                MessageBox.Show("You ate a spiked Zebra Cake and died, your game will be reset now.");
                Death();
            }
        }
        private void AddItems(Items items)
        {
            foreach (Items item in Inventory.inventory)
            {
                if (item.name == items.name)
                {
                    item.quantity += 1;
                    return;
                }
            }
            Inventory.inventory.Add(items);
        }
        private void SearchTrash()
        { 
            Random rand = new Random();
            int chance = rand.Next(1, 101);
            Items items = new Items("", 0.00m, 0);

            if (chance <= 25)
            {
                items = new Items("Chicken Bones", 0.10m, 1);
                AddItems(items);
            }
            else if (chance > 25 && chance <= 40)
            {
                items = new Items("Half Eaten Steak", 0.20m, 1);
                AddItems(items);
            }
            else if (chance > 40 && chance <= 50)
            {
                items = new Items("Soda Can", 0.50m, 1);
                AddItems(items);
            }
            else if (chance > 50 && chance <= 60)
            {
                items = new Items("Dead Rat", 0.50m, 1);
                AddItems(items);
            }
            else if (chance > 60 && chance <= 69)
            {
                items = new Items("Used Toothbrush", 0.75m, 1);
                AddItems(items);
            }
            else if (chance > 69 && chance <= 75)
            {
                items = new Items("Computer Mouse", 1.00m, 1);
                AddItems(items);
            }
            else if (chance > 75 && chance <= 83)
            {
                items = new Items("Monster Energy Can", 1.00m, 1);
                AddItems(items);
            }
            else if (chance > 83 && chance <= 89)
            {
                items = new Items("Copper Wire", 1.25m, 1);
                AddItems(items);
            }
            else if (chance > 89 && chance <= 94)
            {
                items = new Items("Computer Mouse", 10.00m, 1);
                AddItems(items);
            }
            else if (chance > 94 && chance <= 98)
            {
                items = new Items("Rolex", 150.00m, 1);
                AddItems(items);
            }
            else if (chance > 98 && chance <= 100)
            {
                items = new Items("GTX 710 2Gb", 275.00m, 1);
                AddItems(items);
            }
            Utility.SaveItems(Inventory.inventory);
            Utility.GetNewestInventoryData();
            MessageBox.Show($"You have received a {items.name}.");
        }
        private void Add10Health()
        {
            stats.health += 10;
            StartUp();
            Utility.SaveStats(characterStats);
        }
        private void Remove20Health()
        {
            stats.health -= 20;
            CheckHealth();
            StartUp();
            Utility.SaveStats(characterStats);
        }
        private void Death()
        {
            stats.health -= 100;
            CheckHealth();
            DisableButtons();
            MessageBox.Show("You have died, your game will be reset now.");
            Utility.DeleteData1();
            Utility.DeleteData2(Inventory.inventory);
            Utility.SaveStats(characterStats);
            StartUp();
        }
        private void DisableButtons()
        {
            Restart.Visible = true;
            Save.Enabled = false;
            LevelUp.Enabled = false;
            Eat.Enabled = false;
            Search.Enabled = false;
            SellAll.Enabled = false;
            SellOne.Enabled = false;
        }
        private void Add10()
        {
            stats.money += 10;
            StartUp();
            Utility.SaveStats(characterStats);
        }
        private void CheckHealth()
        {
            if (stats.health < 0)
            {
                stats.health = 0;
                DisableButtons();
            }
            else if (stats.health == 0)
            {
                DisableButtons();
            }
            else if (stats.health > 100)
            {
                stats.health = 100;
                MessageBox.Show("You cannot have over 100 health");
            }
        }
        private void InstaLevelUp()
        {
            stats.level += 1;
            StartUp();
            Utility.SaveStats(characterStats);
        }
        private void Reset()
        {
            Restart.Visible = false;
            stats.money = 0;
            stats.level = 0;
            stats.health += 100;
            Save.Enabled = true;
            LevelUp.Enabled = true;
            Eat.Enabled = true;
            Search.Enabled = true;
            SellAll.Enabled = true;
            SellOne.Enabled = true;
            Inventory.inventory.Clear();
            StartUp();
            Utility.SaveStats(characterStats);
            Utility.SaveItems(Inventory.inventory);
        }
        private void SellAllItems()
        {
            decimal sum = 0;
            foreach (Items item in Inventory.inventory)
            {
                sum += item.price * item.quantity;
            }
            stats.money += sum;
            Inventory.inventory.Clear();
            Utility.SaveStats(characterStats);
            Utility.SaveItems(Inventory.inventory);
            StartUp();
            LevelPopUp();
        }
        private void SellOneItem()
        {
            decimal sum = 0;
            Items selectedItem = (Items)InventoryData.CurrentRow.DataBoundItem;
            stats.money += selectedItem.price;
            selectedItem.quantity -= 1;
            if (selectedItem.quantity <= 0)
            {
                Inventory.inventory.Remove(selectedItem);
            }
            Utility.SaveStats(characterStats);
            Utility.SaveItems(Inventory.inventory);
            StartUp();
            LevelPopUp();
        }
        private void LevelPopUp()
        {
            if (stats.level == 0 && stats.money >= 100)
            {
                LevelUp.Visible = true;
            }
            else if (stats.level == 1 && stats.money >= 300)
            {
                LevelUp.Visible = true;
            }
            else if (stats.level == 2 && stats.money >= 600)
            {
                LevelUp.Visible = true;
            }
            else if (stats.level == 3 && stats.money >= 1000)
            {
                LevelUp.Visible = true;
            }
            else if (stats.level == 4 && stats.money >= 1500)
            {
                LevelUp.Visible = true;
            }
            else if (stats.level == 5 && stats.money >= 2100)
            {
                LevelUp.Visible = true;
            }
            else if (stats.level == 6 && stats.money >= 2800)
            {
                LevelUp.Visible = true;
            }
            else
            {
                LevelUp.Visible = false;
            }
        }

        #endregion
    }
}
 