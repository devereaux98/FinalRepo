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
        bool Walk = true;
	}
	// Update is called once per frame
	void Update () 
    {
        while (Walk = true)
        {
            animation.wrapMode = WrapMode.Loop;
        }
	}
}