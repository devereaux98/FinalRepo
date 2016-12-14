//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;
using System.Collections;

public class fireEnemy
{
    public PlayerScript player1 = new PlayerScript();
    public int health = 50;

    public int power = 10;

    public string status = "alive";
    
    public string enemyType = "Fire";

    public int FireAttack (int power)
    {
        player1.subtractArmor(power);
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
    public fireEnemy fe = new fireEnemy();
    public int FireTakeDamage ()
    {
        this.health -= 10;
        return fe.health;
    }
    public string lifeStatus(string status)
    {
        while (fe.health <= 0)
        {
            fe.status = "dead";
            
        }
        return status;
    }
    
    List<int> fireStats = new List<int>();
    public void declareStats()
    {
        fireStats.Add(fe.health);
        fireStats.Add(fe.power);
    }
    
}