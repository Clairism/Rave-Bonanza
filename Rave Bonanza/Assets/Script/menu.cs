	using UnityEngine;
	using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
	using System.Collections;
	
	public class menuScript : MonoBehaviour 
	{
		public Canvas quitMenu;
		public Button startText;
		public Button exitText;
		
		void Start ()
			
		{
			
			startText = startText.GetComponent<Button> ();
			
		}
		
		public void ExitPress() //this function will be used on our Exit button
			
		{
			
			startText.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
			exitText.enabled = false;
			
		}
		
		public void NoPress() //this function will be used for our "NO" button in our Quit Menu
			
		{
			
			startText.enabled = true; //enable the Play and Exit buttons again so they can be clicked
			exitText.enabled = true;
			
		}
		
		public void StartLevel () //this function will be used on our Play button
			
		{
			Application.LoadLevel (1); //this will load our first level from our build settings. "1" is the second scene in our game
			
		}
		
		public void ExitGame () //This function will be used on our "Yes" button in our Quit menu
			
		{
			
			
		}

}