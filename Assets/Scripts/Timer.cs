﻿using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	private float startTime;
	public string textTime;

	void Awake () {
		startTime = Time.time;
	}

	void OnGUI () {
		float guiTime = Time.time - startTime - 2.5f;

		int minutes = (int)guiTime / 60;
		int seconds = (int)guiTime % 60;
		int fracSec = (int)(guiTime * 100) % 100;

		textTime = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fracSec);
		GUI.Label (new Rect (800, 550, 100, 1000), textTime); 
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
