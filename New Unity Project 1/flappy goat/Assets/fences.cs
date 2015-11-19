using UnityEngine;
using System.Collections;

public class fences : MonoBehaviour {

	public class Obstacle : MonoBehaviour
	{
		public Vector2 velocity = new Vector2(-4, 0);
		
		// Use this for initialization
		void Start()
		{
			GetComponent<Rigidbody2D>().velocity = velocity;
		}
	}
}