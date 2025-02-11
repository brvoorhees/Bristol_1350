using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
  public class Player
  {
      protected int playerId;
      protected int character;
      protected int cart;
      protected int cartPosition;
      public int PlayerId
      {
          get { return playerId; }
          set { playerId = value; }
      }

        public int Character
        {
            get { return character; }
            set { character = value; }
        }
        public int Cart
      {
          get { return cart; }
          set { cart = value; }
      }
      public int CartPosition
      {
          get { return cartPosition; }
          set { cartPosition = value; }
      }

      public Player(int pId, int character, int cartPos)
      {
          Character = character;
          PlayerId= pId;
          CartPosition = cartPos;
      }

      public static void PlayerDetails(List<Player> players)
      {
          for (int i = 0; i < players.Count; i++)
          {
              players[i].Details();
          }
      }
      

      public void Details()
      {
          
          Console.WriteLine($"\nPlayer ID:{PlayerId}, PlayerCharacter:{character}, PlayerCartPosition: {CartPosition}");
      }


  }
}
