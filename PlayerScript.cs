//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System.Collections.Generic;

public class PlayerScript
{
    public GameScript gs = new GameScript();
    public string name; 
    public int health = 100;
    public int armor = 100;
    public int magic = 50;
    public string[] magicType = {"fire", "water", "grass"};
    public string[] items = {"potion", "elixir", "gold", "armor"};
    public int potionCount = 1;
    public int elixirCount = 1;
    public int goldCount = 100;
    public fireEnemy fe = new fireEnemy();
    public int subtractArmor (int power)
    {
        armor -= power;
        return armor;
    }
    public string[] declareArray()
    {
        foreach (string item in items)
        {
            System.Console.WriteLine("{0} ", item);
        }
        foreach (string mt in magicType)
        {
            System.Console.WriteLine("{0} ", mt);
        }
        return items;
    }
    
    List<int> playerStats = new List<int>();
    public void declareStats()
    {
        playerStats.Add(this.health);
        playerStats.Add(this.armor);
        playerStats.Add(this.magic);
        while (this.health > 0)
        {
            gs.Game = true;
        }
    }
    
}
