﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

	// Use this for initialization
	Text instruction;
	void Start () 
	{
		int HealthNum = 100;
		instruction = GetComponent<Text>();
		instruction.text = ("Health: " + HealthNum);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
