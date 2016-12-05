using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	// Use this for initialization
	HealthText instruction;
	void Start () 
	{
		instruction = GetComponent<Text>();
		instruction.text = ("Health: 20");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
