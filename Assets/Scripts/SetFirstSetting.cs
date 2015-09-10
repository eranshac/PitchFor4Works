using UnityEngine;
using System.Collections;

public class SetFirstSetting : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (PlayerPrefsManager.GetIsFirstTime() == 0) {

			PlayerPrefsManager.SetHighestPitch (380);
			PlayerPrefsManager.SetLowhestPitch (120);
		}



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
