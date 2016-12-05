using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlphaScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Color tmp = TextBox.GetComponent<SpriteRenderer>().color;
 		tmp.a = 0f;
 		TextBox.GetComponent<SpriteRenderer>().color = tmp;
		SpriteRenderer.color = new Color(1f,1f,1f,0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
