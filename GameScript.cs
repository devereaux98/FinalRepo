//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;
using System.Collections;

public class GameScript
{
    public PlayerScript player1 = new PlayerScript();
    public bool Game = true;
    public void adventureStart ()
    {
        System.Console.WriteLine(" Welcome stranger!  Our wonderful town of Codeville is being rampaged by corrupted and incorrect javascript files!  You must help us! ");
        System.Console.WriteLine("What is your name stranger?");
        player1.name = System.Console.ReadLine(); 
    }
    void reponses()
    {
        switch (player1.name)
        {
            case "Dev":
                Console.WriteLine("What have you gotten yourself into?");
                break;
            case "Anthony":
                Console.WriteLine("Go easy on me");
                break;
        }
    }
    
    public void itemGet ()
    {
        System.Console.WriteLine(" Thank you for helping us, " + player1.name + ".  Here are some supplies to help you on your journey. ");
        System.Console.WriteLine(" *Obtained " + player1.armor + " Armor*");
        System.Console.WriteLine(" *Obtained " + player1.magic + " Magic*");
        System.Console.WriteLine(" *Obtained " + player1.goldCount + " Gold*");
        System.Console.WriteLine(" *Obtained " + player1.potionCount + " Potion(s)*");
        System.Console.WriteLine(" *Obtained " + player1.elixirCount + " Elixir(s)*");
    }
    public void instructionFunction()
    {
        System.Console.WriteLine(" When you engage in a Battle with one of the bad codes, you will have a number of options of what to do. ");
        System.Console.WriteLine(" The first choice is to Attack.  Use this to engage with your enemie and deal damage using your enemies and deal damage using your magic. ");
        System.Console.WriteLine(" There are 3 types of magic spells, and 3 different kinds of code monsters, respectively. ");
        System.Console.WriteLine(" The types of code monster and spells are Water, Grass, and Fire. ");
        System.Console.WriteLine(" You only have so much Magic, however.  So when you begin to run low, use an Elixir, by choosing Items. ");
        System.Console.WriteLine(" When you slay a code monster, they will drop loot, which can vary from Gold to more supplies. ");
        System.Console.WriteLine(" The supplies I gave you will not last forever, however.  Luckily on your quest there will be some shops in which you can buy more things using Gold. ");
        System.Console.WriteLine(" Good luck, " + player1.name + ". ");
    }
    public void instruction()
    {
        System.Console.WriteLine(" Would you like to know how to play? ");
        String instructions = System.Console.ReadLine();
        switch (instructions)
        {
            case "yes":
                instructionFunction();
                break;
            case "YES":
                instructionFunction();
                break;
            case "Yes":
                instructionFunction();
                break;
            default:
                System.Console.WriteLine(" Very well.  Good luck on your adventure, " + Player.name + "! ");
                break;
        }
        
    }
    public fireEnemy fe = new fireEnemy();
    void EnemyAppear()
    {
        
        switch (fe.enemyType)
        {
            case "fire":
                System.Console.WriteLine("A fire enemy has appeared!");
                break;
            case "water":
                System.Console.WriteLine("A water enemy has appeared!");
                break;
            case "grass":
                System.Console.WriteLine("A grass enemy has appeared!");
                break;
        }
    }
    public GameScript gs = new GameScript();
    void GameOver()
    {
        
        switch (gs.Game)
        {
            case true:
                System.Console.WriteLine("Game is continuing");
                break;
            case false:
                System.Console.WriteLine("Game Over");
                break;
        }
    }
}
