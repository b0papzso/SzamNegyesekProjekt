using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamNegyesekProjekt
{
    public class Table
    {
        public int[] TableGame(int[][] table)
        {
            int[][] newBoard = [
          [table[0][0], table[0][0]+table[0][2], table[0][2]],
        [table[0][0]+table[2][0], table[0][0]+table[2][0]+table[0][2]+table[2][2], table[0][2]+table[2][2]],
        [table[2][0], table[2][0]+table[2][2], table[2][2]]
          ];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table[i][j] != newBoard[i][j])
                    {
                        return [-1];
                    }
                }
            }
            return [table[0][0], table[0][2], table[2][0], table[2][2]];
        }
    }
}
