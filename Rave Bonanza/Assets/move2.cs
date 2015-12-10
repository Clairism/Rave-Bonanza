using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public int playerSpeed = 5;
	
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("a")) 
		{
			GetComponent<Rigidbody>().position += Vector3.left * playerSpeed * Time.deltaTime;
			
		}
		if (Input.GetKey ("d")) 
		{
			
			GetComponent<Rigidbody>().position += Vector3.right * playerSpeed * Time.deltaTime;
		}
		if (Input.GetKey("w")) 
		{
			GetComponent<Rigidbody>().position += Vector3.up * playerSpeed * Time.deltaTime;
			
		}
		if (Input.GetKey ("s")) 
		{
			
			GetComponent<Rigidbody>().position += Vector3.down * playerSpeed * Time.deltaTime;
		}
		
	}
}﻿