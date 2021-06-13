using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HareGame.Game
{
    public static class PlayerFactory
    {
        public static Player GetInstance(int number)
        {
            Player player = null;
            if(number == 1)
            {
                player = new Jasper();
            }
            else if( number == 2 )
            {
                player = new Xavier();
            }
            else if( number == 3 )
            {
                player = new Jaxon();
            }
            return player;
        }
    }
}
