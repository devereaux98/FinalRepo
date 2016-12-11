//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

public class GameScript
{
    void adventureStart ()
    {
        Console.WriteLine(" 'Welcome stranger!  Our wonderful town of Codeville is being rampaged by corrupted and incorrect javascript files!  You must help us!' ");
        Player.name = Console.ReadLine(" 'What is your name, stranger?' ");
    }
    adventureStart();
    void itemGet ()
    {
        Console.WriteLine(" 'Thank you for helping us, " + Player.name + ".  Here are some supplies to help you on your journey.' ");
        Console.WriteLine(" *Obtained " + Player.armor + " Armor*");
        Console.WriteLine(" *Obtained " + Player.magic + " Magic*");
        Console.WriteLine(" *Obtained " + Player.goldCount + " Gold*");
        Console.WriteLine(" *Obtained " + Player.potionCount + " Potion(s)*");
        Console.WriteLine(" *Obtained " + Player.elixirCount + " Elixir(s)*");
    }
    itemGet();
    void instructionFunction ()
    {
        Console.WriteLine(" 'When you engage in a Battle with one of the bad codes, you will have a number of options of what to do. '");
        Console.WriteLine(" 'The first choice is to Attack.  Use this to engage with your enemie and deal damage using your enemies and deal damage using your magic. '");
        Console.WriteLine(" 'There are 3 types of magic spells, and 3 different kinds of code monsters, respectively. '");
        Console.WriteLine(" 'The types of code monster and spells are Water, Grass, and Fire.' ");
        Console.WriteLine(" 'You only have so much Magic, however.  So when you begin to run low, use an Elixir, by choosing Items. '");
        Console.WriteLine(" 'When you slay a code monster, they will drop loot, which can vary from Gold to more supplies.' ");
        Console.WriteLine(" 'The supplies I gave you will not last forever, however.  Luckily on your quest there will be some shops in which you can buy more things using Gold.' ");
        Console.WriteLine(" 'Good luck, " + Player.name + ".' ");
    }
    void instruction ()
    {
        String instruction = Console.ReadLine(" 'Would you like to know how to play?' ");
    }
}