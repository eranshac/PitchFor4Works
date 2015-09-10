using UnityEngine;
using System.Collections;

public class MuteScript : MonoBehaviour {

	// Use this for initialization

	public Sprite soundOn;
	public Sprite soundOff;
	void Start () {
		if (PlayerPrefsManager.GetVolumeIsOn() == 0)
			GetComponent<SpriteRenderer> ().sprite = soundOn;
		else
			GetComponent<SpriteRenderer> ().sprite = soundOff;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
