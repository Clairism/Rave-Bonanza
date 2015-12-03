using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{

	public float playerSpeed;
	private float rotateSpeed = 1.2f;
	private float xSpeed;
	private float ySpeed;
	public float jumpSpeed = 20.0f;
	private float jumpPlayerSpeed;
	public float playerGravity = -35.0f;
	
	void Start ()
	{
		
		playerSpeed = 25f;
	
	}
	
	void Update ()
	{
		xSpeed = Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime;
		ySpeed = Input.GetAxis ("Vertical") * playerSpeed * Time.deltaTime;

		jumpPlayerSpeed = Input.GetAxis ("Jump") * jumpSpeed * Time.deltaTime;
		
		transform.Translate (Vector3.forward * xSpeed);
		transform.Translate (Vector3.left * ySpeed);

		transform.Translate (Vector3.up * jumpPlayerSpeed);

		Physics.gravity = new Vector3(0, playerGravity, 0);


		transform.Rotate (0, (Input.GetAxis ("Mouse X") * rotateSpeed), 0, Space.World);


	}

}
