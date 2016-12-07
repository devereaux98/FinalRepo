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
	}
	// Update is called once per frame
	void Update () 
    {
        while (GameScript.Walk = false)
        {
            
            GetComponent<Animation>().Stop(Player10);
        }
	}
}