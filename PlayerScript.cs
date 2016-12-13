//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;
using System.Collections.Generic;

public class Player
{
    public String name;
    int health = 100;
    int armor = 100;
    int magic = 50;
    string[] magicType = {"fire", "water", "grass"};
    string[] items = {"potion", "elixir", "gold", "armor"};
    int potionCount = 1;
    int elixirCount = 1;
    int goldCOunt = 100;
    int subtractArmor (power)
    {
        this.armor -= power;
        return Player.armor;
    }
    List<string> playerStats = new List<string>();
    playerStats.add(Player.health);
    playerStats.add(Player.armor);
    playerStats.add(Player.magic);
}
