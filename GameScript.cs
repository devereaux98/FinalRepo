//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public class GameScript
{
    void adventureStart ()
    {
        System.Console.WriteLine(" Welcome stranger!  Our wonderful town of Codeville is being rampaged by corrupted and incorrect javascript files!  You must help us! ");
        Player.name = System.Console.ReadLine(" What is your name, stranger? ");
    }
    adventureStart();
    void itemGet ()
    {
        System.Console.WriteLine(" Thank you for helping us, " + Player.name + ".  Here are some supplies to help you on your journey. ");
        System.Console.WriteLine(" *Obtained " + Player.armor + " Armor*");
        System.Console.WriteLine(" *Obtained " + Player.magic + " Magic*");
        System.Console.WriteLine(" *Obtained " + Player.goldCount + " Gold*");
        System.Console.WriteLine(" *Obtained " + Player.potionCount + " Potion(s)*");
        System.Console.WriteLine(" *Obtained " + Player.elixirCount + " Elixir(s)*");
    }
    itemGet();
    void instructionFunction ()
    {
        System.Console.WriteLine(" When you engage in a Battle with one of the bad codes, you will have a number of options of what to do. ");
        System.Console.WriteLine(" The first choice is to Attack.  Use this to engage with your enemie and deal damage using your enemies and deal damage using your magic. ");
        System.Console.WriteLine(" There are 3 types of magic spells, and 3 different kinds of code monsters, respectively. ");
        System.Console.WriteLine(" The types of code monster and spells are Water, Grass, and Fire. ");
        System.Console.WriteLine(" You only have so much Magic, however.  So when you begin to run low, use an Elixir, by choosing Items. ");
        System.Console.WriteLine(" When you slay a code monster, they will drop loot, which can vary from Gold to more supplies. ");
        System.Console.WriteLine(" The supplies I gave you will not last forever, however.  Luckily on your quest there will be some shops in which you can buy more things using Gold. ");
        System.Console.WriteLine(" Good luck, " + Player.name + ". ");
    }
    void instruction ()
    {
        String instructions = Console.ReadLine(" Would you like to know how to play? ");
        if (instructions == 'yes' || 'Yes' || 'YES')
        {
            instructionFunction();
        }
        else
        {
            System.Console.WriteLine(" Very well.  Good luck on your adventure, " + Player.name + "! ");
        }
    }
    instruction();
}