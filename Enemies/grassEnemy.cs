//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public static class grassEnemy
{
    int health = 60;
    int power = 10;
    string status = ("alive");
    String enemyType = ("Grass");

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
    grassStats.add(grassEnemy.health);
    grassStats.add(grassEnemy.power);
}