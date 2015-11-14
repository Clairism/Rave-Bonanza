using UnityEngine;
using System.Collections;

public class gameTimer : MonoBehaviour {
	/// INPUT VARIBLES
	public GUIStyle timerStyle;
	//public bool countdown = false; //switches between countdown and countup	
	
//	public float hours = 0f;
//	public float minutes = 1f;
//	public float seconds = 30f;

	//public bool printDebug = false;
	
	/// TIMER VARIABLES
	public bool stopTimer = false;
	
	private float timer = 0f;
	private float milsec;
	private float sec;
	private float min;
//	private float hrs;	
	
	/// DISPLAY VARIABLES
//	private string strHours = "00";
//	private string strMinutes = "00";
//	private string strSeconds = "00";
//	
//	private string strHrs = "00";
	private string strMin = "00";
	private string strSec = "00";
	private string strMilSec = "00";
	
	private string message = "Timing...";
	
	// Use this for initialization
	void Start () {		
			milsec = 0f;
			sec = 0f;
			min = 0f;

	}//end start
	
	// Update is called once per frame
	void Update () {	

		CountUp();

		if(stopTimer) {
			Time.timeScale = 0;
		} 

	}
	
	//Timer starts at 00:00:00 and counts up until reaches Time limit
	void CountUp() {
		timer += Time.deltaTime;

		if(timer >= 0.01f){
			milsec++;
			timer = 0f;
		}
		if(milsec >= 60) {
			sec++;
			milsec = 0f;
		}
		
		if(sec >= 60) {
			min++;
			sec = 0f;
		}
		
//		if(min >= 60) {
//			hrs++;
//			min = 0f;
//		}
		
	/*	if(sec >= seconds && min >= minutes && hrs >= hours) {
			sec = seconds;
			min = minutes;
			hrs = hours;
			message = "Time limit reached!";
			if(printDebug) print("TimerCS - Out of time!");
		}
		*/
	}
	
	public void FormatTimer () {
		if(milsec < 10) {
			strMilSec = "0" + milsec.ToString();
		} else {
			strMilSec = milsec.ToString();
		}
		if(sec < 10) {
			strSec = "0" + sec.ToString();
		} else {
			strSec = sec.ToString();
		}
		
		if(min < 10) {
			strMin = "0" + min.ToString();
		} else {
			strMin = min.ToString();
		}
		
//		if(hrs < 10) {
//			strHrs = "0" + hrs.ToString();
//		} else {
//			strHrs = hrs.ToString();
//		}

		/*
		if(seconds < 10) {
			strSeconds = "0" + seconds.ToString();
		} else {
			strSeconds = seconds.ToString();
		}
		
		if(minutes < 10) {
			strMinutes = "0" + minutes.ToString();
		} else {
			strMinutes = minutes.ToString();
		}
		
		if(hours < 10) {
			strHours = "0" + hours.ToString();
		} else {
			strHours = hours.ToString();
		}
		*/
	}

	/* DISPLAY TIMER */
	void OnGUI () {
		//GUI.Label(new Rect(Screen.width-100,90,300,30), "TIMER (C#)", timerStyle);
		FormatTimer();
		GUI.Label(new Rect(Screen.width-200,10,300,30), strMin + ":" + strSec + ":" + strMilSec, timerStyle);
	}

	/* GETTER & SETTERS */
	public bool GameEnd {
		get {return stopTimer;}
		set {stopTimer = value;}
	}
	
	public string Message {
		get { return message; }
		set { message = value; }
	}

	public float MilSec{
		get {return milsec;}
	}
	//public float milSec
	public float Sec {
		get {return sec;}
	}//end seconds
	
	public float Min {
		get {return min;}
	}//end min
	
}
