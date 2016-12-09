using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Display : MonoBehaviour 
{
	// Use this for initialization
	Text instruction;
	void Start () 
	{
		instruction = GetComponent<Text>();
		instruction.text = ("A " + GameScript.Enemy + " appeared!");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
