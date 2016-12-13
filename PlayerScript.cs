//Devereaux Legakis
//Anthony Romrell
//C-Sharp Final

using System;

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
    int subtractHealth (power)
    {
        this.health -= power;
    }
    int subtractArmor (power)
    {
        this.armor -= power;
    }
}
