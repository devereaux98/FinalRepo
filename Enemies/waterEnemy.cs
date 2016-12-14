//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public static class waterEnemy
{
    int health = 50;
    int power = 9;
    string status = ("alive");
    String enemyType = ("Water");

    public int waterAttack (int power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
            return Player.health;
        }
    }

    public int waterTakeDamage ()
    {
        this.health -= 10;
        return waterEnemy.health;
    }
    while (waterEnemy.health <= 0)
    {
        status = ("dead");
    }
    List<string> waterStats = new List<string>();
    waterStats.add(waterEnemy.health);
    waterStats.add(waterEnemy.power);
}
