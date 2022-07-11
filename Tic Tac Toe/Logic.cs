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
        private string[,] fieldMap = new string[3, 3];

        public void NextPlayer()
        {
            if (CurrentPlayer == X)
            {
                CurrentPlayer = O;
            }
            else { CurrentPlayer = X; }
        }

        //ToDo
        public bool isWon()
        {
          /*  if (CurrentPlayer)
            {

            }*/
            return true;

        }


    }
}
