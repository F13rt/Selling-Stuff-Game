using Selling_Stuff_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Selling_Stuff_Game
{
    public class Utility
    {
        #region Lists

        public static List<CharacterStats> stats;
        public static Inventory inventory;

        #endregion
        #region Load Data and Update Data

        public static List<CharacterStats> LoadData1()
        {
            List<CharacterStats> statData = new List<CharacterStats>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\tmielke1\source\repos\Selling Stuff Game\Data.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');
                        int health = Int32.Parse(values[0]);
                        int level = Int32.Parse(values[1]);
                        decimal money = Decimal.Parse(values[2]);

                        CharacterStats stat = new CharacterStats(health, level, money);
                        statData.Add(stat);
                    }
                }
                stats = statData;
                return stats;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data1: " + ex.Message);
                return stats;
            }
        }
        public static BindingList<Items> LoadData2()
        {
            BindingList<Items> inventoryData = new BindingList<Items>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\tmielke1\source\repos\Selling Stuff Game\Data2.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');
                        string name = values[0];
                        decimal price = Decimal.Parse(values[1]);
                        int quantity = Int32.Parse(values[2]);

                        Items inv = new Items(name, price, quantity);
                        inventoryData.Add(inv);
                    }
                    return inventoryData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data2: " + ex.Message);
                return inventoryData;
            }
        }
        public static CharacterStats GetNewestData()
        {
            return stats.LastOrDefault();
        }
        public static Inventory GetNewestInventoryData()
        {
            return new Inventory(LoadData2());
        }

        #endregion
        #region Save Data

        public static void SaveStats(List<CharacterStats> stats)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\source\repos\Selling Stuff Game\Data.txt"))
                {
                    foreach (CharacterStats stat in stats)
                    {
                        sw.WriteLine($"{stat.health},{stat.level},{stat.money}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data1: " + ex.Message);
            }
        }
        public static void SaveItems(BindingList<Items> items)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\source\repos\Selling Stuff Game\Data2.txt"))
                {
                    foreach (Items item in items)
                    {
                        sw.WriteLine($"{item.name},{item.price},{item.quantity}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data2: " + ex.Message);
            }
        }

        #endregion
        #region Delete Data

        public static void DeleteData1()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(""))
                {
                    sw.WriteLine("0,0,0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error wiping data1" + ex.Message);
            }
        }
        public static void DeleteData2(BindingList<Items> items)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tmielke1\source\repos\Selling Stuff Game\Data2.txt"))
                {
                    foreach (Items item in items)
                    {
                        sw.WriteLine($"{item.name},{item.price},0");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data2: " + ex.Message);
            }
        }

        #endregion
    }
}
