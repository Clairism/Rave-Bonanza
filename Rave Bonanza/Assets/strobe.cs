﻿using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Light))]

public class strobe : MonoBehaviour {

	public float time = .5f; 

	// Use this for initialization
	void Start () {
		StartCoroutine("Flicker");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Flicker(){
		while(true){
			GetComponent<Light>().enabled = false;
			yield return new WaitForSeconds(time);
			GetComponent<Light>().enabled = true;
			yield return new WaitForSeconds(time);
		}
	}
}

