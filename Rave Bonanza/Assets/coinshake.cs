using UnityEngine;
using System.Collections;

public class coinspin: MonoBehaviour {

	public float myRotationSpeed = 100f;

	public bool isRotateX = false;
	public bool isRotateY = false;
	public bool isRotateZ = false;

	bool positiveRotation = false;
	private int posOrNeg = 1;
	// Use this for initialization
	void Start () {
	
		if (positiveRotation == false) {
			posOrNeg = -1;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	if (isRotateX) 
		{
			transform.Rotate (myRotationSpeed * Time.deltaTime * posOrNeg, 0, 0);
		}
	

	if(isRotateY) 

	{
		transform.Rotate(0, myRotationSpeed * Time.deltaTime * posOrNeg, 0);
	}

	if(isRotateZ) {
			transform.Rotate(0, 0, myRotationSpeed * Time.deltaTime * posOrNeg);
	}	
	}	
}