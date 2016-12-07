using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Display : MonoBehaviour 
{
	// Use this for initialization
	Text instruction;
	void Start () 
	{
		while (GameScript.Walk = true)
		{
			GameObject DisplayText = GameObject.Find("DisplayText");
			Color tmp = DisplayText.GetComponent<SpriteRenderer>().color;
 			tmp.a = 0f;
			DisplayText.GetComponent<SpriteRenderer>().color = tmp;
		}
		instruction = GetComponent<Text>();
		instruction.text = ("A " + GameScript.Enemy + " appeared!");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
