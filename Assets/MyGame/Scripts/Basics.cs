﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basics : MonoBehaviour {

    public Text overrideText;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        overrideText.text = "Dinky, Winky, Dipsy, LaLa, Poo";
	}
	
	// Update is called once per frame
	void Update () {
    //  Debug.Log("alive");
    }
}
