using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
    public class DiceResults
    {
        public DiceResults() { }
        public int Matches(string d1, string d2)
        {
            int match = d1.CompareTo(d2);
            return match;
        }

        public void ActualDiceResults(int d1, int d2, int d3, int d4, int d5, int d6)
        {
            RollMeaning rollMeaning = new RollMeaning();
            Matches matches = new Matches();

            int nDice1 = 1;
            int nDice2 = 2;
            int nDice3 = 3;
            int nDice4 = 4;
            int nDice5 = 5;
            int nDice6 = 6;

            int dicei1 = d1;
            int dicei2 = d2;
            int dicei3 = d3;
            int dicei4 = d4;
            int dicei5 = d5;
            int dicei6 = d6;

            string dices1 = rollMeaning.Roll(dicei1);
            string dices2 = rollMeaning.Roll(dicei2);
            string dices3 = rollMeaning.Roll(dicei3);
            string dices4 = rollMeaning.Roll(dicei4);
            string dices5 = rollMeaning.Roll(dicei5);
            string dices6 = rollMeaning.Roll(dicei6);
            Console.WriteLine("\nDice Results are:\n");
            Console.WriteLine($"   Dice 1 {dices1} \n   Dice 2 {dices2} \n   Dice 3 {dices3} \n   Dice 4 {dices4} \n   Dice 5 {dices5} \n   Dice 6 {dices6}\n");

            matches.rMatches(dices1, dices2, dices3, dices4, dices5, dices6, nDice1, nDice2, nDice3, nDice4, nDice5, nDice6);
        }
    }
}
