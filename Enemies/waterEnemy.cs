//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

public class waterEnemy
{
    int health = 50;
    int power = 9;
    String enemyType = ("Water");

    int waterAttack (int power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
        }
    }

    int waterTakeDamage ()
    {
        this.health -= 10;
    }
}
