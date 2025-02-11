using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
    public class RollMeaning
    {
        public string Roll(int roll) 
        { 
            if (roll == 1)
            {
                return "Cart_1 Apple";
            }
            else if (roll == 2)
            {
                return "Cart_2 Apple";
            }
            else if (roll == 3)
            {
                return "Cart_3 Apple";
            }
            else if (roll == 4)
            {
                return "Cart_1 Rat";
            }
            else if (roll == 5)
            {
                return "Cart_2 Rat";
            }
            else if (roll == 6)
            {
                return "Cart_3 Rat";
            }
            else
            {
                return "Not a valid number";
            }
        }

    }
}
