//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public class fireEnemy
{
    int health = 50;

    int power = 10;

    string status = ("alive");
    
    String enemyType = ("Fire");

    public int FireAttack (int power)
    {
        Player.subtractArmor();
        if (Player.armor == 0)
        {
            Player.health -= power;
            return Player.health;
        }
    }

    public int FireTakeDamage ()
    {
        this.health -= 10;
        return fireEnemy.health;
    }
    while (fireEnemy.health <= 0)
    {
        status = ("dead");
    }
    List<string> fireStats = new List<string>();
    fireStats.add(fireEnemy.health);
    fireStats.add(fireEnemy.power);
}