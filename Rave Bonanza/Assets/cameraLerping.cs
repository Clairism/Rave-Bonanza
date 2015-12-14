using UnityEngine;
using System.Collections;

public class cameraLerping : MonoBehaviour {

	//GameObject playerCameraPoint;

	public Transform startPoint;
	public Transform endPoint;

	float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		startPoint = GameObject.Find ("startPoint").transform;

		endPoint = GameObject.Find ("endPoint").transform;

		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, speed);
	}
}
