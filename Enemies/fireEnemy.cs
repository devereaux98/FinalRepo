//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

public class fireEnemy
{
    int health = 50;

    int power = 10;
    
    String enemyType = ("Fire");

    public FireAttack (int power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
        }
    }

    public FireTakeDamage ()
    {
        this.health -= 10;
    }
}