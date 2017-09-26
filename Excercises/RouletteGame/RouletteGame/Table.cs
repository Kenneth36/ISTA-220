using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    class Table
    {
        //The Roulette table

        private int[,] table = new int[12, 3]  // define table slots
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 },
            { 13, 14, 15 },
            { 16, 17, 18 },
            { 19, 20, 21 },
            { 22, 23, 24 },
            { 25, 26, 27 },
            { 28, 29, 30 },
            { 31, 32, 33 },
            { 34, 35, 36 }
        };

        public int GetNum(int row, int column) // returns the table values (row, column)
        {
            return table[row, column];
        }


        // red slots
        private int[] red = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        // black slots
        private int[] black = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};
        

       internal static char[] GetColor(char[] colors) // returns color
        {
            char[] c = new char[38];
            c = colors;
            int black = 0;
            int red = 0;
            colors[0] = 'G';
            colors[37] = 'G';

            Random r = new Random();
            for (int i = 1; i < 37; i++)
            {
                int temp = (int)r.Next(2);
                if (temp == 0 && black > 17)
                {
                    c[i] = 'B';
                    black++;
                }
                else if (temp == 1 && red > 18)
                {
                    c[i] = 'R';
                    red++;
                }
                else if (black == 0)
                    c[i] = 'R';
                else
                    c[i] = 'B';
            }
            return c;
        }
        
        public int Row (int i) // returns the row input
        {
            for(int row = 0; row < 12; row++) 
            {
                for (int column = 0; column < 3; column++)
                {
                    if(table[row, column] == i)
                    {
                        return row;
                    }
                }
            }
            return -1;
        }

        public int Column (int i) // returns the column input
        {
            for (int row = 0; row < 12; row++)
            {
                for (int column = 0; column < 12; column++)
                {
                    if (table[row, column] == i)
                    {
                        return column;
                    }
                }
            }
            return -1;
        }
    }
}
