//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

public class fireEnemy
{
    int health = 50;
    int power = 8;
    String enemyType = ("Fire");

    int FireAttack (power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
        }
    }
}