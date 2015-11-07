using UnityEngine;
using System.Collections;

public class movingFolks : MonoBehaviour
{

	public float velMax;
	public float xMax;
	public float zMax;
	public float xMin;
	public float zMin;
	private float x;
	private float z;
	private float timeGap;
	private float direction;
	
	// Use this for initialization
	void Start ()
	{
		
		x = Random.Range (-velMax, velMax);
		z = Random.Range (-velMax, velMax);
		direction = Mathf.Atan2 (x, z) * (180 / 3.141592f) + 20;
		transform.localRotation = Quaternion.Euler (0, direction, 0);
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		timeGap = Time.deltaTime;
		
		if (transform.localPosition.x > xMax) {
			x = Random.Range (-velMax, 0.0f);
//			direction = Mathf.Atan2 (x, z) * (180 / 3.141592f) + 20;
			transform.localRotation = Quaternion.Euler (0, direction, 0);
			timeGap = 0.0f; 
		}

		if (transform.localPosition.x < xMin) {
			x = Random.Range (0.0f, velMax);
//			direction = Mathf.Atan2 (x, z) * (180 / 3.141592f) + 20;
			transform.localRotation = Quaternion.Euler (0, direction, 0); 
			timeGap = 0.0f; 
		}

		if (transform.localPosition.z > zMax) {
			z = Random.Range (-velMax, 0.0f);
//			direction = Mathf.Atan2 (x, z) * (180 / 3.141592f) + 20;
			transform.localRotation = Quaternion.Euler (0, direction, 0); 
			timeGap = 0.0f; 
		}

		if (transform.localPosition.z < zMin) {
			z = Random.Range (0.0f, velMax);
//			direction = Mathf.Atan2 (x, z) * (180 / 3.141592f) + 20;
			transform.localRotation = Quaternion.Euler (0, direction, 0);
			timeGap = 0.0f; 
		}
		

		if (timeGap > 2.0f) {
			x = Random.Range (-velMax, velMax);
			z = Random.Range (-velMax, velMax);
			direction = Mathf.Atan2 (x, z) * (180 / 3.141592f) + 20;
			transform.localRotation = Quaternion.Euler (0, direction, 0);
			timeGap = 0.0f;
		}
		
		transform.localPosition = new Vector3 (transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
	}
}
