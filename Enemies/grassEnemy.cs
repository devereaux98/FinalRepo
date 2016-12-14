//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;
using System.Collections;

public class grassEnemy
{
    public int health = 60;
    public int power = 10;
    public string status = "alive";
    public string enemyType = "Grass";

    public int grassAttack (int power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
            return Player.health;
        }
        else
        {
            Console.WriteLine("No damage taken!");
        }
        
    }

    public int grassTakeDamage ()
    {
        this.health -= 10;
        return grassEnemy.health;
    }
    while (grassEnemy.health <= 0)
    {
        status = ("dead");
    }
    List<string> grassStats = new List<string>();
    public void declareStats()
    {
        grassStats.Add(grassEnemy.health);
        grassStats.Add(grassEnemy.power);
    }
    
}