using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceGame
    {
        public int[] SimulateRolls(int numRolls)
        {
            Random random = new Random();
            int[] result = new int[13]; 

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                result[sum]++;
            }

            return result;
        }
    }
}
