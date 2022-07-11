using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Logic
    {
        public string CurrentPlayer { get; set; } = X;
        private const string X = "X";
        private const string O = "O";
        //////////////////////////////For positioning
        private string[,] fieldMap = new string[3, 3];
        public int firstCoordinate { get; set; }
        public int secondCoordinate { get; set; }

        public void NextPlayer()
        {
            if (CurrentPlayer == X)
            {
                CurrentPlayer = O;
            }
            else { CurrentPlayer = X; }
        }
        public bool isWon()
        {

                ///first check horizontal(rows)
                for (int i = 0; i < 3; i++)
                {    //check if first value in row have value if not skip
                    if (!String.IsNullOrEmpty(fieldMap[i, 0]))
                    {    //check if all values are equal in particular row
                        if (fieldMap[i, 0] == fieldMap[i, 1] && fieldMap[i, 0] == fieldMap[i, 2])
                            return true;
                    }

                }
                ///check for vertical(columns)
                for (int j = 0; j < 3; j++)
                {
                    if (!string.IsNullOrEmpty(fieldMap[0, j]))
                    {
                        if (fieldMap[0, j] == fieldMap[1, j] && fieldMap[0, j] == fieldMap[2, j])
                            return true;
                    }


                }
                ///check for diagonal(1)
                if (!string.IsNullOrEmpty(fieldMap[1, 1]))
                {
                    if (fieldMap[0, 0] == fieldMap[1, 1] && fieldMap[0, 0] == fieldMap[2, 2])
                        return true;
                }

                ///check for diagonal(2)
                if (!string.IsNullOrEmpty(fieldMap[1, 1]))
                {
                    if (fieldMap[0, 2] == fieldMap[1, 1] && fieldMap[0, 2] == fieldMap[2, 0])
                        return true;
                }
            return false;

        }


        //method for uptading the gameboard(fieldmap)
        internal void Update(Logic position, string currentPlayer)
        {
            fieldMap[firstCoordinate, secondCoordinate] = currentPlayer;
        }
    }
}
