using UnityEngine;
using System.Collections;

public class DungeonStill : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		gamescript = GetComponent<GameScript>();
		while (GameScript.Walk == false)
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Dungeon1.png");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
