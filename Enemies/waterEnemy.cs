//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public class waterEnemy
{
    public PlayerScript player1 = new PlayerScript();
    public waterEnemy we = new waterEnemy();
    public int health = 50;
    public int power = 9;
    public string status = "alive";
    public string enemyType = "Water";

    public int waterAttack (int power)
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

    public int waterTakeDamage ()
    {
        we.health -= 10;
        return we.health;
    }
    public string lifeStatus(string status)
    {
        while (we.health <= 0)
        {
            status = ("dead");
        }
        return status;
    }
    List<int> waterStats = new List<int>();
    public void declareStats()
    {
        waterStats.Add(we.health);
        waterStats.Add(we.power);
    }
    
}
