using System.Collections.Generic;

namespace Selling_Stuff_Game
{
    public class CharacterStats
    {
        #region Properties and List

        public List<CharacterStats> stats;
        public int health { get; set; }
        public int level { get; set; }
        public decimal money { get; set; }

        #endregion
        public CharacterStats(int health, int level, decimal money)
        {
            this.health = health;
            this.level = level;
            this.money = money;
            stats = new List<CharacterStats>();
        }
    }
}
