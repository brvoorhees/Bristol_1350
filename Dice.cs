using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
    public class Dice
    {
       RollMeaning roll = new RollMeaning();
      public int DiceInt()
        {
            int randNum;
            Random rand = new Random();

            randNum = rand.Next(1, 7);
            return randNum;
        }
        public string DiceString(int randNum)
        {
            string result = roll.Roll(randNum);
           return result;
        }
        public int DiceRoll()
        {
            Dice dice = new Dice();

            int dicei1 = dice.DiceInt();
            string dices1 = dice.DiceString(dicei1);

            return dicei1;


        }
       
        
        //public string Dice2()
        //{
        //    int randNum;
        //    Random rand = new Random();

        //    randNum = rand.Next(1, 7);
        //    string result = roll.Roll(randNum);
        //    Console.WriteLine($"You rolled a {result}");
        //    return result;
        //}
        //public string Dice3()
        //{
        //    int randNum;
        //    Random rand = new Random();

        //    randNum = rand.Next(1, 7);
        //    string result = roll.Roll(randNum);
        //    Console.WriteLine($"You rolled a {result}");
        //    return result;
        //}
        //public string Dice4()
        //{
        //    int randNum;
        //    Random rand = new Random();

        //    randNum = rand.Next(1, 7);
        //    string result = roll.Roll(randNum);
        //    Console.WriteLine($"You rolled a {result}");
        //    return result;
        //}
        //public string Dice5()
        //{
        //    int randNum;
        //    Random rand = new Random();

        //    randNum = rand.Next(1, 7);
        //    string result = roll.Roll(randNum);
        //    Console.WriteLine($"You rolled a {result}");
        //    return result;
        //}
        //public string Dice6()
        //{
        //    int randNum;
        //    Random rand = new Random();

        //    randNum = rand.Next(1, 7);
        //    string result = roll.Roll(randNum);
        //    Console.WriteLine($"You rolled a {result}");
        //    return result;
        //}
    }
}
