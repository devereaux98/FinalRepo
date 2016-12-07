using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour 
{
	public static string Enemy;
    public static bool Walk;
    
    // Use this for initialization
    void Start () 
    {
        string Enemy = ("Spider");
        bool Walk = false;
        GameObject Player10 = GameObject.Find("Player10");
        Animation animation = GetComponent<Animation>().Play();
	}
	// Update is called once per frame
	void Update () 
    {
        while (GameScript.Walk = true)
        {
            
            animation.Play(Player10);
        }
	}
}