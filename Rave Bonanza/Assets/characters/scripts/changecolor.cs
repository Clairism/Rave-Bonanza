using UnityEngine;
using System.Collections;

public class changecolor : MonoBehaviour {
	public float colourChangeDelay = 0.5f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;
	
	void OnCollisionEnter(Collision other) {
		Debug.Log("Contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
	}
	void checkColourChange()
	{        
		if(colourChangeCollision)
		{
			transform.GetComponent<Renderer>().material.color = Color.yellow;
			if(Time.time > currentDelay)
			{
				transform.GetComponent<Renderer>().material.color = Color.white;
				colourChangeCollision = false;
			}
		}
	}
	
	void Update()
	{
		checkColourChange();
}
}