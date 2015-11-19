using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public Vector2 jumpForce = new Vector2 (-50,300);
	// Use this for initialization


	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetKeyUp("space"))
			{
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce(jumpForce);
			}

	}
}
