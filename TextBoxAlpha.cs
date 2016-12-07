using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextBoxAlpha : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GameObject TextBox = GameObject.Find("TextBox");
		Color tmp = TextBox.GetComponent<SpriteRenderer>().color;
 		tmp.a = 0f;
 		TextBox.GetComponent<SpriteRenderer>().color = tmp;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
