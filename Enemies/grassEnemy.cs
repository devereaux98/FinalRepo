//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

public class grassEnemy
{
    int health = 60;
    int power = 10;
    String enemyType = ("Grass");

    public int grassAttack (int power)
    {
        Player.armor -= power;
        if (Player.armor == 0)
        {
            Player.health -= power;
            return Player.health;
        }
        
    }

    public int grassTakeDamage ()
    {
        this.health -= 10;
        return grassEnemy.health;
    }
}