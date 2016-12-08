﻿using UnityEngine;
using System.Collections;


/*

VaporPlace is a script that is attached to the VaporPlace prefab

By: Nathan Young and Elena Sparacio

*/
public class VaporPlace : MonoBehaviour {

	//image credits: https://upload.wikimedia.org/wikipedia/commons/c/c4/Fire_Texture_01.png

	BlobPlayer blobPlayer;
	Temperature temp;

	// Use this for initialization
	void Start () {

		GameObject actualBlob = GameObject.Find ("ActualBlob");
		blobPlayer = actualBlob.GetComponent<BlobPlayer> ();
		temp = GameObject.Find ("Temperature").GetComponent<Temperature> ();

	}

	// Update is called once per frame
	void Update () {
		

	}

	//when the player enters the area, change the powers of the player
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			blobPlayer.SetState ("vapor");
			temp.setTemp (2);
		}
	}

	//note, when destroyed, must say outside circle
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			blobPlayer.SetState ("ice");
			temp.setTemp (0);

		}
	}

}