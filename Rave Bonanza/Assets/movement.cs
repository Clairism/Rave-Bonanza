

using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	private Vector3 relative;
	void Example() {
		relative = transform.InverseTransformDirection(0, 0, 1);
		Debug.Log(relative);
	}
}
