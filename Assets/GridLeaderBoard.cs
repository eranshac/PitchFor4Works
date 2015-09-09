using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GridLeaderBoard : MonoBehaviour {

	// Use this for initialization

	void Start () {
		FB.Init (Update);
	}
	
	// Update is called once per frame
	void Update () {

		if (FB.IsLoggedIn) {
			GameObject.Find("Text").GetComponent<Text>().text="loggedin";
			GetComponent<UIPanel> ().alpha = 1;
			Leaderboards leaderboard = GameObject.Find ("Leaderboard").GetComponent<Leaderboards> ();
			leaderboard.GetLeaderboard ();

		} else  {
			GameObject.Find("Text").GetComponent<Text>().text="loggedout";
			GetComponent<UIPanel>().alpha=0f;
		}
	}
}
