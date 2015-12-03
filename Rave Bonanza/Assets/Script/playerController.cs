using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{

	public float playerSpeed;
	private float rotateSpeed = 1.2f;
	private float xSpeed;
	private float ySpeed;
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;
//	private Vector3 moveDirection = Vector3.zero;
	
	void Start ()
	{
		
		playerSpeed = 25f;
		
	}
	
	void Update ()
	{
		xSpeed = Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime;
		ySpeed = Input.GetAxis ("Vertical") * playerSpeed * Time.deltaTime;

		jumpSpeed = Input.GetAxis ("Jump") * jumpSpeed * Time.deltaTime;
		
		transform.Translate (Vector3.forward * xSpeed);
		transform.Translate (Vector3.left * ySpeed);

		transform.Translate (Vector3.up * jumpSpeed);
		
		
		transform.Rotate (0, (Input.GetAxis ("Mouse X") * rotateSpeed), 0, Space.World);


		//CharacterController controller = GetComponent<CharacterController>();
		//if (controller.isGrounded) {
			//moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			//moveDirection = transform.TransformDirection(moveDirection);
			//moveDirection *= playerSpeed;
//		if (Input.GetKey(KeyCode.Space)) {
//			
//			transform.position += Vector3.up * playerSpeed * Time.deltaTime;
//		} else{
//			
//			transform.position += Vector3.down * playerSpeed  * Time.deltaTime;
//			
//		}
		
		//moveDirection.y -= gravity * Time.deltaTime;

		//controller.Move(moveDirection * Time.deltaTime);
		//}

	}

}
