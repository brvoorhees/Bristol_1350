using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{

    public class Character
    {
        int charId;
        string color;
        string specialAbility;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string SpecialAbility
        {
            get { return specialAbility; }
            set { specialAbility = value; }
        }

        public int Id
        {
            get { return charId; }
            set { charId = value; }
        }
        public Character()
        {

        }
        public Character (int id, string colr, string sAbility)
        {
            charId = id;
            color = colr;
            specialAbility = sAbility;
        }

       
        

        public void CharaDisplay()
        {
            Console.WriteLine($"{Id},{Color},{SpecialAbility}");
        }
    }
    

}
//public enum Character
//{
    

//}
