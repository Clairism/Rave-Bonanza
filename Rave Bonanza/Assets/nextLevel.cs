using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	public GUIStyle scoreStyle;

	int currentLevel;
	GameObject timerCount;

	private float Min;
	private float Sec;
	private float MilSec;

	private string strMin = "00";
	private string strSec = "00";
	private string strMilSec = "00";

	void Start () {

	currentLevel = Application.loadedLevel;
	timerCount = GameObject.Find ("timer");
	
	}
	
	// Update is called once per frame
	void Update () {

		
		Min = timerCount.GetComponent<gameTimer>().Min;
		Sec = timerCount.GetComponent<gameTimer>().Sec;
		MilSec = timerCount.GetComponent<gameTimer>().MilSec;

		if(Input.GetKey (KeyCode.R)){
			Application.LoadLevel(currentLevel);
		}
	
	}

	void OnTriggerEnter(Collider other){

		timerCount.GetComponent<gameTimer>().stopTimer = true;

		strMin = "Min";
		strSec = "Sec";
		strMilSec = "MilSec";

	}

	void OnGui(){

		timerCount.GetComponent<gameTimer>().FormatTimer();
		
		GUI.Label(new Rect(Screen.width/2-100,Screen.height/2-20,300,30), strMin + ":" + strSec + ":" + strMilSec, scoreStyle);
	}
}
