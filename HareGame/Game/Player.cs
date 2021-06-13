using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareGame.Game
{
    public class Player
    {

        public string Name { get; set; }

        public int Amount { get; set; }

        public GameBet Bet { get; set; }

        public Label Label { get; set; }

        public RadioButton Radio { get; set; }

        public TextBox TextBox { get; set; }

        public bool Busted()
        {
            return Amount == 0;
        }
    }
}
