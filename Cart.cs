using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
    public class Cart
    {
        protected int cartPosition;
        int leaches;
        List <Player> playerIDs;

        public int CartPosition
        {
            get { return cartPosition; }
            set { cartPosition = value; }
        }
        public int Leaches
        { 
            get { return leaches; }
            set { leaches = value; } 
        }

        public void NCart(int cPosition, List<Player> playerids)
        {
            CartPosition = cPosition;
            playerIDs = playerids;
            
        }
        public void NCart(int cPosition, List<Player> playerids, int leach)
        {
            CartPosition = cPosition;
            playerIDs = playerids;
            Leaches = leach;
        }
        public void CartDetails(List<Player> playerIds)
        {
            for (int i = 0; i < playerIds.Count(); i++)
            {
                int p = i;
                playerIds[p].Details();
            }
        }
        //    Console.WriteLine($" at space {CartPosition} with ");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int player = playerIds[i].PlayerId;
        //        int playerPosition = playerIds[i].CartPosition;
        //        Console.WriteLine($"player {player} in cart position {playerPosition}");
        //    }

        //    //CartName = cName;
        //    //Leaches = leach;
        //    //PlayerID = pID;

        //}
    }
    
        
}
