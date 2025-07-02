using Selling_Stuff_Game.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Selling_Stuff_Game
{
    public partial class Extras : Form
    {
        #region Properties and List

        CharacterStats stats;
        public static List<CharacterStats> characterStats;
        public static Inventory Inventory;

        #endregion
        #region Main Constructor

        public Extras()
        {
            InitializeComponent();
            characterStats = Utility.LoadData1();
            Inventory = new Inventory(Utility.LoadData2());
        }

        #endregion
        #region Button Clicks

        private void ExportData1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Users\tmielke1\Downloads\Data.txt"))
            {
                File.Create(@"C:\Users\tmielke1\Downloads\Data.txt").Close();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\Downloads\Data.txt"))
                {
                    foreach (CharacterStats stat in characterStats)
                    {
                        sw.WriteLine($"{stat.health},{stat.level},{stat.money}");
                    }
                }
                MessageBox.Show("Your save file has been exported to your downloads folder");
            }
            else
            { 
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\Downloads\Data.txt"))
                {
                    foreach (CharacterStats stat in characterStats)
                    {
                        sw.WriteLine($"{stat.health},{stat.level},{stat.money}");
                    }
                }
                MessageBox.Show("Your save file in your downloads folder has been overwritten");
            }
        }
        private void ExportData2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Users\tmielke1\Downloads\Data2.txt"))
            { 
                File.Create(@"C:\Users\tmielke1\Downloads\Data2.txt").Close();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\Downloads\Data2.txt"))
                {
                    foreach (Items item in Inventory.inventory)
                    {
                        sw.WriteLine($"{item.name},{item.price},{item.quantity}");
                    }
                }
                MessageBox.Show("Your save file has been exported to your downloads folder");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\Downloads\Data2.txt"))
                {
                    foreach (Items item in Inventory.inventory)
                    {
                        sw.WriteLine($"{item.name},{item.price},{item.quantity}");
                    }
                }
                MessageBox.Show("Your save file in your downloads folder has been overwritten");
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }

        #endregion
    }
}
