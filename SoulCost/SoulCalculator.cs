using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulCost
{
    class SoulCalculator
    {
        public int SoulsForLevel(int level)
        {
            double cost;

            if (level < 13)
            {
                cost = 0.0068 * Math.Pow(level, 3) - 0.06 * Math.Pow(level, 2) + 17.1 * level + 639;
            }
            else
            {
                cost = 0.02 * Math.Pow(level, 3) + 3.06 * Math.Pow(level, 2) + 105.6 * level - 895;
            }

            return (int) Math.Round(cost);
        }

        public int SoulsForRange(int startLevel, int endLevel)
        {
            int cost = 0, level = startLevel;

            while (level < endLevel)
            {
                level++;
                cost += SoulsForLevel(level);
            }

            return cost;
        }

        public string SoulsForRangeString(int startLevel, int endLevel)
        {
            return String.Format("Total souls cost to level up from {0} to {1}:  {2}", startLevel, endLevel, SoulsForRange(startLevel, endLevel));
        }
    }
}