using Bristol_1350;
using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Xml;

Console.WriteLine("Your task is to make it out of town in one of three carts available without anyone who is sick.");

Console.WriteLine("Some may contract a sickness, but they don't want to be found out so they don't get left behind");

Console.WriteLine("If you leave town with a sick person you will get sick and die as well.");
Console.WriteLine("You must do all that you can to prevent this from happening!");


List<Player> c1list = new List<Player>();
List<Player> c2list = new List<Player>();
List<Player> c3list = new List<Player>();

Cart cart1 = new Cart();
Cart cart2 = new Cart();
Cart cart3 = new Cart();

CharacterCollection collection = new CharacterCollection();

List<Character> list = new List<Character>();
Character character1 = new Character(1, "White", "Something Awesome");
list.Add(character1);
Character character2 = new Character(2, "Green", "Something Awesomer");
list.Add(character2);
Character character3 = new Character(3, "Purple", "Something Awesome1");
list.Add(character3);
Character character4 = new Character(4, "Blue", "Something Awesomer1");
list.Add(character4);
Character character5 = new Character(5, "Black", "Something Awesome2");
list.Add(character5);
Character character6 = new Character(6, "Brown", "Something Awesomer2");
list.Add(character6);
Character character7 = new Character(7, "Yellow", "Something Awesome3");
list.Add(character7);
Character character8 = new Character(8, "Orange", "Something Awesomer3");
list.Add(character8);
Character character9 = new Character(9, "Red", "Something Awesome4");
list.Add(character9);

Console.WriteLine("How many players?");
int numPlayers = int.Parse(Console.ReadLine());

//bool reset = false;
//while (reset != false)
//{
int d1 = 1;
int d2 = 1;
int d3 = 1;
for (int i = 0; i < numPlayers; i++)
{ 
    int p = i + 1;
   
    collection.CharaDisplay(list);
    Console.WriteLine("Which player would you like to be?");

    int select = 1;// int.Parse(Console.ReadLine());
        
    if (p == 1 || p == 4 || p == 7)
    {
        Player player = new Player(p, select, d1);
        c1list.Add(player);
        d1+=1;
    }
    else if (p == 2 || p == 5 || p == 8)
    {
     Player player = new Player(p, select, d2);
        c2list.Add(player);
        d2+=1;
    }
    else if (p == 3 || p == 6 || p == 9)
    {
        Player player = new Player(p, select, d3);
        c3list.Add(player);
        d3+=1;
    }
}
cart1.NCart(0, c1list);
cart2.NCart(0, c2list);
cart3.NCart(0, c3list);

    Dice dice = new Dice();
int dicei1 = dice.DiceRoll();
int dicei2 = dice.DiceRoll();
int dicei3 = dice.DiceRoll();
int dicei4 = dice.DiceRoll();
int dicei5 = dice.DiceRoll();
int dicei6 = dice.DiceRoll();

DiceResults dresults = new DiceResults();
dresults.ActualDiceResults(dicei1, dicei2, dicei3, dicei4, dicei5, dicei6);

for (int p = 1; p <= numPlayers; p++)
{
    Console.WriteLine("\nCart 1");
    cart1.CartDetails(c1list);
    Console.WriteLine("\nCart 2");
    cart2.CartDetails(c2list);
    Console.WriteLine("\nCart 3");
    cart3.CartDetails(c3list);

    Console.WriteLine($"Player ID: {p}, would you like to re-roll 1 or 2 of the die?");
    int selRe_Roll = int.Parse(Console.ReadLine());
    int re_roll = 0;
    int re_roll2 = 0;

    for (int i = 0; i < selRe_Roll; i++)
    {
        int lastRoll = i;
        if (lastRoll == numPlayers - 2)
        {
            Console.WriteLine("Last roll for the round");
        }
        if (selRe_Roll == 1)
        {
            Console.WriteLine("Which die would you like to re-roll?");
            re_roll = int.Parse(Console.ReadLine());
        }
        else if (selRe_Roll == 2)
        {
            if (i == 0)
            {
                Console.WriteLine("Which die would you like to re-roll first?");
                re_roll = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Which die would you like to re-roll second?");
                re_roll2 = int.Parse(Console.ReadLine());
            }
        }
    }
    if (selRe_Roll == 1)
        Console.WriteLine($"Section was {re_roll}");
    else if (selRe_Roll == 2)
        Console.WriteLine($"Selection was {re_roll} and {re_roll2}");
    else
        break;
    for (int i = 0; i < selRe_Roll; i++)
    {
        if (re_roll == 1)
        {
            re_roll = 0;
            dicei1 = dice.DiceRoll();
        }
        else if (re_roll == 2)
        {
            re_roll = 0;
            dicei2 = dice.DiceRoll();
        }
        else if (re_roll == 3)
        {
            re_roll = 0;
            dicei3 = dice.DiceRoll();
        }
        else if (re_roll == 4)
        {
            re_roll = 0;
            dicei4 = dice.DiceRoll();
        }
        else if (re_roll == 5)
        {
            re_roll2 = 0;
            dicei5 = dice.DiceRoll();
        }
        else if (re_roll == 6)
        {
            re_roll = 0;
            dicei6 = dice.DiceRoll();
        }
        else if (re_roll2 == 1)
        {
            re_roll2 = 0;
            dicei1 = dice.DiceRoll();
        }
        else if (re_roll2 == 6)
        {
            re_roll2 = 0;
            dicei6 = dice.DiceRoll();
        }
        else if (re_roll2 == 5)
        {
            re_roll2 = 0;
            dicei5 = dice.DiceRoll();
        }
        else if (re_roll2 == 4)
        {
            re_roll2 = 0;
            dicei4 = dice.DiceRoll();
        }
        else if (re_roll2 == 3)
        {
            re_roll2 = 0;
            dicei3 = dice.DiceRoll();
        }
        else if (re_roll2 == 2)
        {
            re_roll2 = 0;
            dicei2 = dice.DiceRoll();
        }       
        else
        {
            Console.WriteLine("Not a valid die number!");
        }
        dresults.ActualDiceResults(dicei1, dicei2, dicei3, dicei4, dicei5, dicei6);

    }
}

    //rollMatch.StringMatches(dices1, dices2, dices3, dices4, dices5, dices6);

Console.WriteLine("Time to compare");

//int rPMatch2 = rollMatch.Matches(poMatch2, poMatch3);
//int rPMatch3 = rollMatch.Matches(poMatch2, poMatch4);
//int rPMatch4 = rollMatch.Matches(poMatch2, poMatch5);
//int rPMatch5 = rollMatch.Matches(poMatch2, poMatch6);
//}

//Console.WriteLine("Select a Color and it must be unique.");
//string color = Console.ReadLine();
////var char1 = nameof(Character);
//// var charName = nameof(Character.Lady);
//// Console.WriteLine($"Char1 { char1} and CharName { charName}");
//Console.WriteLine("What is your secret power?");
//string secretPower = Console.ReadLine();
//Character character = new Character(color, secretPower);

//Player player = new Player(p, character, d);
//c1list.Add(player);
//    Character character = new Character();
//    character = character.CharacterColor();

//    Player player = new Player(p, character, d);
//    c2list.Add(player);
//    Console.WriteLine("Select a Color and it must be unique.");
//    string color = Console.ReadLine();
//    Console.WriteLine("What is your secret power?");
//    string secretPower = Console.ReadLine();
//    Character character = new Character(color, secretPower);






//}


//if ()playerp

//Console.WriteLine($" Player {p} is going to be ");
//Console.WriteLine(Enum.GetValues(typeof(Character)));
//Console.WriteLine($"");
//var characterSelect = Console.ReadLine();



//////Console.WriteLine("Who's turn is it?");
//////int playTurn = int.Parse(Console.ReadLine());
//////Console.WriteLine("What action are you looking to take? 1. Roll, 2. Draw a Remedy, 3. Make a Pawn Movment");
//////int playOption = int.Parse(Console.ReadLine());

//////if (playOption == 1)
//////    {
//////    Console.WriteLine("Pick which dice you would like to role");

//////    }
//////else if (playOption == 2)
//////{
//////    Console.WriteLine("Your Remedy card has been added to your Remedies pile");
//////}
//////else if (playOption == 3)
//////{
//////    Console.WriteLine("What pawn movement would you like to make? \n Elbow (move in front of another player) \n Dash (Move to the back of the cart in front of your own... If you are in the front of your current cart) \n Push (Yourself or someone else to the last spot on the last wagon, or the last spot on the second wagon from the end, or your left behind and need to reveal sickness status... If sick the player who pushed you is now dead from heart break");
//////}
//////Console.WriteLine("Would you like to use a Remedy? 1. Yes");
//////int useRemedy = int.Parse(Console.ReadLine());

//////if (useRemedy == 1)
//////{
//////    Console.WriteLine("Which Remedy would you like to utilize?");
//////}
//Game Play
//Actions =
//Roll any 1-2 of the 6 dice
//Draw 1 Remedy Card
//Pawn Movement
//--Elbow - Move in front of another player,
//--Dash - Move to the back of cart in front of yours (only if you are at front of your current cart) If cart in front of you is full you swap places with the person in the back, if the spot is open  the others in your previous cart shift forward
//--Push - Push a pawn off your cart (Push yourself, or someone one or two spots behind you) Move to the last cart last spot if empty, if not then you move to the last spot of the second wagon, if not then you move to the last spot of the first wagon... Other players in former cart move forward to fill in spaces (if no space is available behind the person that is pushed is left behind, if they aren't sick then the person that pushed them dies of a broken heart for pushing)
//
//Remedies can be played in addition to other action on your turn except for Whip (Can use one action from as many cards as you would like, outside of newly obtained cards)
//--Arsenic - lock two dice for the round (if all 6 get locked no re-rolling can be done for the round)
//--Chicken - Additional 3 roles for two dice (if one of the two lands as expected you can choose to only role one of the two original dice)
//--Crushed Emeralds - 1 extra pawn movment (Action doesn't have to be a pawn movment)
//--Leeches - Draw 2 symptoms and choose 1 to add to any cart's minble stack (your own included) NOTE: only one of these cards will be included in the mingle others are discarded
//--Pomander - Draw 2 symptoms and choose 2 of the 4 to keep (don't add your symptoms together while doing this)
//--Whip - Prevent someone from dashing, elbowing past you, or pushing you off a cart (played in order starting with round initiator, Can be used during turn)
//
//
//Winning - Be the first to leave the city with no sick cart members, if anyone is sick in the cart the whole cart dies and other carts have 1 more turn to get out before the gates are shut. An empty cart can exit the city without triggering the end of the game


//Player player1 = new Player(1, "Riddler", 1);
//Player player2 = new Player(2, "Witch", 2);
//Player player3 = new Player(3, "Popper", 3);
//Player player4 = new Player(4, "Riddler1", 1);
//Player player5 = new Player(5, "Witch1", 2);
//Player player6 = new Player(6, "Popper1", 3);
//Player player7 = new Player(7, "Riddler2", 1);
//Player player8 = new Player(8, "Witch2", 2);
//Player player9 = new Player(9, "Popper2",3);

//c1list.Add(player1);
//c1list.Add(player2); 
//c1list.Add(player3); 
//c2list.Add(player4); 
//c2list.Add(player5); 
//c2list.Add(player6); 
//c3list.Add(player7); 
//c3list.Add(player8); 
//c3list.Add(player9);

////Console.WriteLine("\nCart 1");
////

//c1list.Remove(player1);
//c1list.Remove(player2);
//c1list.Add(player1);
//c1list.Add(player2);


////Console.WriteLine("\nCart 1");
////for (int i = 0; i < c1list.Count(); i++)
////{

////    int p = i;
////    if (p == 1 || p == 2)
////        c1list[p].Details();
////    else
////    {
////        Console.WriteLine($"Player {p} moved to the front of the wagon");
////        c1list[p].Details();
////    }


////}

////Cart cart1 = new Cart();
////Cart cart2 = new Cart();
////Cart cart3 = new Cart();

////cart1.NCart(0, c1list);
////cart2.NCart(0, c2list);
////cart3.NCart(0, c3list);

////cart1.CartPosition = 3;

//Console.WriteLine("Cart 1 details");
//cart1.CartDetails(c1list);
//Console.WriteLine("Cart 2 details");
//cart2.CartDetails(c2list);
//Console.WriteLine("Cart 3 details");
//cart3.CartDetails(c3list);

