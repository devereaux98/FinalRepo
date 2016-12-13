//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public class waterEnemy
{
    int health = 50;
    int power = 9;
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
}
