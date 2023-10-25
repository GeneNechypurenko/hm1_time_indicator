using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hm1_miner
{
    public class MineField
    {
        private bool[,] field;
        public MineField()
        {
            Random rand = new Random();

            const int row = 3;
            const int col = 3;
            field = new bool[row, col];

            int minesToSet = 3;
            int minesSet = 0;

            while (minesSet < minesToSet)
            {
                int i = rand.Next(row);
                int j = rand.Next(col);

                if (!field[i, j])
                {
                    field[i, j] = true;
                    minesSet++;
                }
            }
        }
        public bool this[int i, int j]
        {
            get { return field[i, j]; }
        }
    }
}
