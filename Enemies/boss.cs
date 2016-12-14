//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System.Collections.Generic;

public class boss
{
    public PlayerScript player1 = new PlayerScript();
    public boss ba = new boss();
    public int health = 200;
    public int power = 14;
    public string status = ("alive");
    public string bossName = ("Anthony Romrell");

    public void bossAttack ()
    {
        
        for (int i = 0; i < 5; i++)
        {
            while (i < 5)
            {
                player1.health -= 5;
            }
        }
    }
    List<int> bossStats = new List<int>();
    public void declareStats()
    {
        bossStats.Add(ba.health);
        bossStats.Add(ba.power);
    }
    
}