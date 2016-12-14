//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public static class boss
{
    int health = 200;
    int power = 14;
    string status = ("alive");
    String bossName = ("Anthony Romrell");

    public int bossAttack ()
    {
        for (int i = 0; i < 5; i++)
        {
            while (i < 5)
            {
                Player.health -= 5;
            }
        }
    }
    List<object> bossStats = new List<object>();
    bossStats.add(boss.health);
    bossStats.add(boss.power);
}