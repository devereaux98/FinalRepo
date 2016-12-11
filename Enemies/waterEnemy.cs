//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

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
        }
    }

    public int waterTakeDamage ()
    {
        this.health -= 10;
    }
}
