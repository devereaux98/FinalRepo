//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public class grassEnemy
{
    public PlayerScript player1 = new PlayerScript();
    public grassEnemy ge = new grassEnemy();
    public int health = 60;
    public int power = 10;
    public string status = "alive";
    public string enemyType = "Grass";

    public int grassAttack (int power)
    {
        player1.armor -= power;
        if (player1.armor == 0)
        {
            player1.health -= power;
            return player1.health;
        }
        else
        {
            Console.WriteLine("No damage taken!");
            return player1.health;
        }
        
    }

    public int grassTakeDamage ()
    {
        ge.health -= 10;
        return ge.health;
    }
    public string lifeStatus()
    {
        while (ge.health <= 0)
        {
            status = ("dead");
        }
        return status;
    }
    
    List<int> grassStats = new List<int>();
    public void declareStats()
    {
        grassStats.Add(ge.health);
        grassStats.Add(ge.power);
    }
    
}