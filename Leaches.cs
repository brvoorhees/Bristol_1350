using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
    public class Leaches
    {
        int numberOfLeaches;
        int leachPower;

        public int NumberOfLeaches
        {
            get { return numberOfLeaches; }
            set { numberOfLeaches = value; }
        }

        public int LeachPower
        {
            get { return leachPower; }
            set { leachPower = value; }
        }

        public Leaches( int numberLeach, int leachPow)
        {
            numberOfLeaches = numberLeach;
            leachPower = leachPow;
        }
    }
}
