using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour
{

	public GUIStyle scoreStyle;
	 GameObject timerCount;
	private float Min;
	private float Sec;
	private float MilSec;
	private string strMin = "00";
	private string strSec = "00";
	private string strMilSec = "00";
	public bool triggered;


	 void Start ()
	{

		timerCount = GameObject.Find ("timer");
		triggered = false;
	
	}

	void Update ()
	{

	Min = timerCount.GetComponent<gameTimer> ().Min;
		Sec = timerCount.GetComponent<gameTimer> ().Sec;
		MilSec = timerCount.GetComponent<gameTimer> ().MilSec;

	}

	 void FormatTimer ()
	{
		if (MilSec < 10) {
			strMilSec = "0" + MilSec.ToString ();
		} else {
			strMilSec = MilSec.ToString ();
		}
		if (Sec < 10) {
			strSec = "0" + Sec.ToString ();
		} else {
			strSec = Sec.ToString ();
		}
		
		if (Min < 10) {
			strMin = "0" + Min.ToString ();
		} else {
			strMin = Min.ToString ();
		}

	}


	 void OnTriggerEnter (Collider other)
	{

		if(other.gameObject.tag == "Player"){
			triggered = true;
			timerCount.GetComponent<gameTimer> ().stopTimer = true;
		}
	}


	 void OnGUI ()
	{

		if (triggered) {

			FormatTimer ();
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 20, 300, 30), "You used " + strMin + ":" + strSec + ":" + strMilSec + " to get out!!"+"\n" +"\n" +"Press 'S' ", scoreStyle);
		
		}
	}

	
}
