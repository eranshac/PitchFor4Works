using UnityEngine;
using System.Collections;

public class FloorTrigger : MonoBehaviour {

	public static bool isTouchEnabledFirstTime=false;
	public static bool isTouchEnabledallways=false;
	private static GameObject pauseScreen;
	void Start () {
		pauseScreen=GameObject.Find("PauseScreen");
		pauseScreen.SetActive (false);




	}
	
	// Update is called once per frame
	public void LoadLevel (string name) {
			

		if(!isTouchEnabledFirstTime){
			// load Pause Screen
			pauseScreen.SetActive (true);
			pauseScreen.gameObject.SetActive(true);
			Time.timeScale = 0;

			}
			else{
			//
			if(isTouchEnabledallways){
			Application.LoadLevel(name);
			}
		
		}
	}
	void OnTriggerEnter2D(Collider2D flask){
		print ("flask tag" + flask.gameObject.tag);
		if (flask.gameObject.tag =="MoreInformationFlask" && Application.loadedLevelName == "MainMenu") {
			Application.LoadLevel("Options");
		} 
		if(flask.gameObject.tag =="PlayFlask" && PlayerPrefsManager.GetIsFirstTime()==1){

			Application.LoadLevel ("GAME");
		}
		if(flask.gameObject.tag =="PlayFlask" && PlayerPrefsManager.GetIsFirstTime()==0){
			
			Application.LoadLevel ("SetUserPitch");
		}
		if(flask.gameObject.tag =="BackButton" && Application.loadedLevelName == "Options" ){
			Application.LoadLevel ("MainMenu");
		}
		if(flask.gameObject.tag =="BackButton" && Application.loadedLevelName == "Settings" ){
			Application.LoadLevel ("Options");
		}
		if(flask.gameObject.tag =="SettingFlask" && Application.loadedLevelName == "Options" ){
			Application.LoadLevel ("Settings");
		}

		if (Application.loadedLevelName == "SetUserPitch") {

			GetUserPitch getUserPitch = GameObject.Find ("GetUserPitch").GetComponent<GetUserPitch> ();
			if (flask.gameObject.tag == "SetHighPitch") {

				getUserPitch.CheckHighestPitch ();
			}

			if (flask.gameObject.tag == "SetLowPitch") {
				
				getUserPitch.CheckLowestPitch ();
				
			}
			if (flask.gameObject.tag == "BackButton" || flask.gameObject.tag == "UseDefaultPitch") {
				if (flask.gameObject.tag == "UseDefaultPitch") {
					PlayerPrefsManager.SetHighestPitch (380);
					PlayerPrefsManager.SetLowhestPitch (120);
				
				}
				if (PlayerPrefsManager.GetIsFirstTime () == 1) {

					Application.LoadLevel ("Settings");
				
				} else {
					Application.LoadLevel ("GAME");
				}
		
			}
			/*	if(flask.gameObject.tag ==""){
			Application.LoadLevel ("");
		}
		if(flask.gameObject.tag ==""){
			Application.LoadLevel ("");
		}
		if(flask.gameObject.tag ==""){
			Application.LoadLevel ("");
		}*/

		}
	}
}
