//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

public class fireEnemy
{
    int health = 50;
    
    String enemyType = ("Fire");

    int FireAttack (int power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
        }
    }

    int FireTakeDamage ()
    {
        this.health -= 10;
    }
}