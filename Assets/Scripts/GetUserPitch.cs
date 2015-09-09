using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetUserPitch : MonoBehaviour {
	private  float time;
	private  Text HigestPitchText,LowestPitchText;
	private float highestPitch=0,lowestpitch=400;
	private  bool checkHigest = false,checkLowest=false;
	public  Slider highestPitchSlider;
	public  Slider lowestPitchSlider;
	private  float currentTimeForSlider;
	private int count;
	private float sum;
	private bool isFirst;
	public Ball preFarbBall;

	// Use this for initialization
	
	
	
	public void CheckHighestPitch(){

		highestPitchSlider.gameObject.SetActive (true);
		HigestPitchText.fontSize = 17;
		highestPitchSlider.value=0;
		currentTimeForSlider=Time.timeSinceLevelLoad;
		checkHigest=true;
	//	GameObject.Find("ButtonForHigh").GetComponent<Button>().interactable=false;
	//	GameObject.Find("ButtonForLow").GetComponent<Button>().interactable=false;
		GameObject.Find ("StopRight").gameObject.GetComponent<BoxCollider2D> ().isTrigger = false;;
		Invoke("Stop",3);
	}
	public void CheckLowestPitch(){
		lowestPitchSlider.gameObject.SetActive (true);
		LowestPitchText.fontSize = 17;
		lowestPitchSlider.value=0;
		currentTimeForSlider=Time.timeSinceLevelLoad;
		checkLowest=true;
	//	GameObject.Find("ButtonForLow").GetComponent<Button>().interactable=false;
	//	GameObject.Find("ButtonForHigh").GetComponent<Button>().interactable=false;
		GameObject.Find ("StopLeft").gameObject.GetComponent<BoxCollider2D> ().isTrigger = false;;
		Invoke("Stop",3);
	}
	
	public void Stop(){
	//	GameObject.Find("ButtonForHigh").GetComponent<Button>().interactable=true;
		//GameObject.Find("ButtonForLow").GetComponent<Button>().interactable=true;
		PlayerPrefsManager.SetHighestPitch(highestPitch);
		PlayerPrefsManager.SetLowhestPitch(lowestpitch);
	checkHigest=false;
		checkLowest=false;
		count=0;
		sum = 0;
		print ("isFirst " + isFirst);
		if (lowestpitch==400 || highestPitch==0) {
			Ball ball = (Ball)Instantiate (preFarbBall, new Vector2 (20.5f, 8.7f), Quaternion.identity);

		} else if (PlayerPrefsManager.GetIsFirstTime ()==0) {
			Application.LoadLevel ("GAME");

		} else {

			Application.LoadLevel ("Settings");
		}
				
	}
	
	
	void Start () {
		HigestPitchText = (Text) GameObject.Find("HigestPitchText").GetComponent<Text>();
		LowestPitchText = (Text) GameObject.Find("LowestPitchText").GetComponent<Text>();
		lowestPitchSlider.gameObject.SetActive (false);

		highestPitchSlider.gameObject.SetActive (false);
		 count=0;
		 sum = 0;
		isFirst = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (checkHigest) {
			highestPitchSlider.value = (Time.timeSinceLevelLoad - currentTimeForSlider) / 3;
			
			if (Controller.x > 0 && Controller.x > 150) {
				count++;
				sum = sum + Controller.x;
				highestPitch = sum / count;

			}
			HigestPitchText.text = "Your highest pitch is: " + ((int)highestPitch).ToString ();
		}	
		if(checkLowest){
		
			lowestPitchSlider.value=(Time.timeSinceLevelLoad-currentTimeForSlider)/3;
			
			if(Controller.x>0 && Controller.x<250){
				count++;
				sum=sum+Controller.x;
				lowestpitch=sum/count;
			}
			LowestPitchText.text="Your lowest pitch is: " + ((int) lowestpitch ).ToString();
		}
			
			
			
			

	//	HigestPitchText.text="Highest Pitch :" + highestPitch.ToString();

	
	
	}
	

}
