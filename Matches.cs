using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bristol_1350
{
    public class Matches
    {
        
        int match1 =1;
        int match2 =1;
        int match3 =1;
        protected string match_1;
        protected string match_2;
        protected string match_3;
        
        int dice1;
        int dice2;
        int dice3;
        int dice4;
        int dice5;
        int dice6;
        

        public int Match1
        {
            get { return match1; }
            set { match1 = value; }
        }
            
        public int Match2
        {
            get { return match2; }
            set { match2 = value; }
        }
        public int Match3
        {
            get { return match3; }
            set { match3 = value; }
        }
        public string Match_1
        {
            get { return match_1; }
            set { match_1 = value; }
        }
        public string Match_2
        {
            get { return match_2; }
            set { match_2 = value; }
        }
        public string Match_3
        {
            get { return match_3; }
            set { match_3 = value; }
        }
        public int Dice1
        {
            get { return dice1; }
            set { dice1 = value; }
        }
        public int Dice2
        {
            get { return dice2; }
            set { dice2 = value; }
        }
        public int Dice3
        {
            get { return dice3; }
            set { dice3 = value; }
        }
        public int Dice4
        {
            get { return dice4; }
            set { dice4 = value; }
        }
        public int Dice5
        {
            get { return dice5; }
            set { dice5 = value; }
        }
        public int Dice6
        {
            get { return dice6; }
            set { dice6 = value; }
        }
        public Matches() 
        {
            string match1;
            string match2;
            string match3;
        }
        public Matches(int id)
        {
            int matches = id;
        }
        public int rMatchesValues(string d, string d1)
        {
            int dId = d.CompareTo(d1);
            if (dId == 0)
                return dId;
            else
                return 1;
        }

        public void rMatches(string d1, string d2, string d3, string d4, string d5, string d6, int di1, int di2, int di3, int di4, int di5, int di6)
        {
            string dices1 = d1;
            string dices2 = d2;
            string dices3 = d3;
            string dices4 = d4;
            string dices5 = d5;
            string dices6 = d6;
            int dicei1 = di1;
            int dicei2 = di2;
            int dicei3 = di3;
            int dicei4 = di4;
            int dicei5 = di5;
            int dicei6 = di6;
            
            Matches rollMatch = new Matches();
            List<Matches> matchesList = new List<Matches>();

            int temp = rollMatch.rMatchesValues(dices1, dices2);
            if (temp == 0)
            {
                
                rollMatch.ListMatches(temp, dices1, dicei1, dicei2);
            }
            temp = rollMatch.rMatchesValues(dices1, dices3);
            if (temp == 0)
            {
                
                rollMatch.ListMatches(temp, dices1, dicei1, dicei3);
            }
            temp = rollMatch.rMatchesValues(dices1, dices4);
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices1, dicei1, dicei4);
            }
            temp = rollMatch.rMatchesValues(dices1, dices5);
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices2, dicei1, dicei5);
            }
            temp = rollMatch.rMatchesValues(dices1, dices6);
            
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices2, dicei1, dicei6);
            }
            temp = rollMatch.rMatchesValues(dices2, dices3);
            if (temp == 0)
            {
               rollMatch.ListMatches(temp, dices2, dicei2, dicei3);
            }
            temp = rollMatch.rMatchesValues(dices2, dices4);
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices2, dicei2, dicei4);
            }
            temp = rollMatch.rMatchesValues(dices2, dices5);
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices2, dicei2, dicei5);
            }
            temp = rollMatch.rMatchesValues(dices2, dices6);
            if (temp == 0)
            {
               rollMatch.ListMatches(temp, dices2, dicei2, dicei6);
            }
            temp = rollMatch.rMatchesValues(dices3, dices4);
           
            if (temp == 0)
            {
              rollMatch.ListMatches(temp, dices3, dicei3, dicei4);
            }
            temp = rollMatch.rMatchesValues(dices3, dices5);
           
            if (temp == 0)
            {
               rollMatch.ListMatches(temp,dices3, dicei3, dicei5);
            }
             temp = rollMatch.rMatchesValues(dices3, dices6);
            
            if (temp == 0)
            {
               rollMatch.ListMatches(temp,dices3, dicei3, dicei6);
            }
            temp = rollMatch.rMatchesValues(dices4, dices5);
            
            if (temp == 0)
            {
                rollMatch.ListMatches(temp,dices4, dicei4, dicei5);
            }
            temp = rollMatch.rMatchesValues(dices4, dices5);
            
            if (temp == 0)
            {
                rollMatch.ListMatches(temp,dices4, dicei4, dicei5);
            }
            temp = rollMatch.rMatchesValues(dices4, dices6);
        
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices4, dicei4, dicei6);
            }
            temp = rollMatch.rMatchesValues(dices5, dices6);
           
            if (temp == 0)
            {
                rollMatch.ListMatches(temp, dices5, dicei5, dicei6);
            }
        }
        public void ListMatches(int pMatch, string dices, int dic1, int dic2)
        {

            if (Match1 != 0)
            {
                Dice1 = dic1;
                Dice2 = dic2;
                Match1 = pMatch;
                Match_1 = dices;
                Console.WriteLine($"Match 1 {Match_1} using {Dice1} and {Dice2}");
            }
            else if (Match2 != 0)
            {
                Dice3 = dic1;
                Dice4 = dic2;
                if (Dice3 != Dice1)
                    if (Dice3 != Dice2)
                        if (Dice4 != Dice1)
                            if (Dice4 != Dice2)
                            {
                                Match2 = pMatch;
                                Match_2 = dices;
                                Console.WriteLine($"Match 2 {Match_2} using {Dice3} and {Dice4}");
                            }

            }
            else if (Match3 != 0)
            {
                Dice5 = dic1;
                Dice6 = dic2;
                if (Dice5 != Dice1)
                    if (Dice5 != Dice2)
                        if (Dice5 != Dice3)
                            if(Dice5 != Dice4)
                                if (Dice6 != Dice1)
                                    if (Dice6 != Dice2) 
                                        if (Dice6 != Dice3)
                                            if (Dice6 != Dice4)
                                            {
                                                Match3 = pMatch;
                                                Match_3 = dices;
                                                Console.WriteLine($"Match 3 {Match_3} using {Dice5} and {Dice6}");
                                            }
                
            }
            
        }
         
        
        
        //    int poMatch3 = 
        //    int poMatch4 = 
        //    int poMatch5 = 
        //    int poMatch6 = 
        //    int poMatch7 = 
        //    int poMatch8 = 
        //    int poMatch9 = 
        //    int poMatch10 = 
        //    int poMatch11 = 
        //    int poMatch12 =
        //    int poMatch13 = 
        //    int poMatch14 = 
        //    int poMatch15 = 
        //    int poMatch16 = 

        //    while (die1_6 < 6)
        //    {
        //        die1_6++;

        //        for (int i = 0; i < 6; i++)
        //        {
        //            if (poMatch2 == 0 || poMatch3 == 0)
        //            {
        //                Matches dMatch = new Matches(poMatch2, dices1);
        //                bool match = false;
        //                bool match1 = false;
        //                if (match == false)
        //                {
        //                    matchesList.Add(dMatch);
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice2");
        //                    match = true;
        //                    break;
        //                }
        //                else if (match1 == false)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice2");
        //                    match1 = true;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices1}.");
        //                }
        //            }
                    
        //            if (poMatch3 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice3");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice3");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices1}.");
        //                }
        //            }
                   
        //            if (poMatch4 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice4");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice4");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices1}.");
        //                }
        //            }
                   
        //            if (poMatch5 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice5");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice5");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices1}.");
        //                }
        //            }
                    
        //            if (poMatch6 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice6");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices1} for dice1 and dice6");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices1}.");
        //                }
        //            }
                    
        //            if (poMatch7 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice3");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice3");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices2}.");
        //                }
        //            }
                    
        //            if (poMatch8 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice4");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice4");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices2}.");
        //                }
        //            }
                    
        //            if (poMatch9 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice5");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice5");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices2}.");
        //                }
        //            }
                    
        //            if (poMatch10 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice6");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices2} for dice2 and dice6");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices2}.");
        //                }
        //            }
                    
        //            if (poMatch11 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices3} for dice3 and dice4");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices3} for dice3 and dice4");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices3}.");
        //                }
        //            }
                    
        //            if (poMatch12 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices3} for dice3 and dice5");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices3} for dice3 and dice5");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices3}.");
        //                }
        //            }
                   
        //            if (poMatch13 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices3} for dice3 and dice6");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices3} for dice3 and dice6");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices3}.");
        //                }
        //            }
                    
        //            if (poMatch14 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices4} for dice4 and dice5");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices4} for dice4 and dice5");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices3}.");
        //                }
        //            }
                 
        //            if (poMatch15 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices4} for dice4 and dice6");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices4} for dice4 and dice6");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices3}.");
        //                }
        //            }
                    
        //            if (poMatch16 == 0)
        //            {
        //                int match = 0;
        //                int match1 = 0;
        //                if (match == 0)
        //                {
        //                    Console.WriteLine($"Match on {dices5} for dice5 and dice6");
        //                    match = 1;
        //                }
        //                else if (match1 == 0)
        //                {
        //                    Console.WriteLine($"Second Match");
        //                    Console.WriteLine($"Match on {dices5} for dice5 and dice6");
        //                    match1 = 1;
        //                    //call something to indicate movement or mingle
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Two matches already exist for {dices3}.");
        //                }
        //            }
        //        }
        //    }
        //}
    
        
    }
}
