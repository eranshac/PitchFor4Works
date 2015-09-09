using UnityEngine;
using System.Collections;

public class PanalScript : MonoBehaviour {


	private bool isAllreadyChanged;
	void Start () {
	//	 UIDrawCall uidraw = GetComponent<UIPanel> ().clipping
		isAllreadyChanged = false;

			//GetComponent<UIPanel> ().clipping.enabled=true;

		//uidraw.enabled = false;
	//	uidraw.enabled = true;
		print ("GetComponent<UIPanel> ().clipping   " +GetComponent<UIPanel> ().clipping);
	}
	
	// Update is called once per frame

	void  ChangeTo1(){
	


		GetComponent<UIPanel> ().clipping = (UIDrawCall.Clipping)1;
		print ("1");
	}
	void  ChangeTo0(){




		GetComponent<UIPanel> ().clipping = (UIDrawCall.Clipping)0;
		print ("0aa");
	}


	void Update () {
		if (FB.IsLoggedIn && !isAllreadyChanged) {
			Invoke("ChangeTo1",1f);
			Invoke("ChangeTo0",2f);
			Invoke("ChangeTo1",3f);


			isAllreadyChanged=true;
		}
	}
}
