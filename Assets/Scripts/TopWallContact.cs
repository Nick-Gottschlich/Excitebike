﻿using UnityEngine;
using System.Collections;

public class TopWallContact : MonoBehaviour {

	float wallSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//need to make this work with moving down to the lane and reducing accel
	//this is for top wall (tag the walls)
	void OnTriggerStay(Collider other){
		/*Bike bikeScript = other.GetComponent<Bike> ();
		PE_Obj bikePEO = other.GetComponent<PE_Obj> ();

		if (bikeScript.curDirIn != Bike.DirInput.UP) {
			bikePEO.vel.z = 0f;
			//tweak
			bikePEO.acc.x = -3f;
		}*/

		PE_Obj bikePEO = other.GetComponent<PE_Obj> ();

		if (bikePEO == null)
			return;

		bikePEO.vel.z = 0f;
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W))
		{
			//bikePEO.vel.z = 0f;
			if (bikePEO.vel.x > wallSpeed) {
				bikePEO.acc.x = -3f;
			}
			//update these values if we tweak bike.cs
			else if (bikePEO.vel.x < wallSpeed) {
				if (Input.GetKey (KeyCode.X) || Input.GetKey (KeyCode.Period)) {
					bikePEO.acc.x = 3.25f;
				}
				else if (Input.GetKey (KeyCode.Z) || Input.GetKey (KeyCode.Comma)) {
					bikePEO.acc.x = 5f;
				}
			}
			else {
				bikePEO.acc.x = 0f;
			}
		}
		

	}

}
