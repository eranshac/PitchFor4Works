using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
		
	const string Highest_Pitch_Key = "Highest Pitch";	
	const string Lowest_Pitch_Key = "Lowest Pitch";	
	const string High_Score_Key = "Higest Score";	
	const string Is_First_Time_Key="Is First Time";
	const string Volume_Is_On="Volume Is On";

	public static void SetVolumeIsOn(int zeroIsTrue){
		
		PlayerPrefs.SetInt (Volume_Is_On,zeroIsTrue);
	}
	
	public static int GetVolumeIsOn(){
		
		return PlayerPrefs.GetInt(Volume_Is_On);
		
	}


	public static void SetIsFirstTime(int zeroIsTrue){
		
		PlayerPrefs.SetInt (Is_First_Time_Key,zeroIsTrue);
	}
	
	public static int GetIsFirstTime(){
		
		return PlayerPrefs.GetInt(Is_First_Time_Key);
		
	}

	public static void SetHighestScore(int points){
		
		PlayerPrefs.SetInt(High_Score_Key,points);
	}
	
	public static int GetHighestScore(){
		
		return PlayerPrefs.GetInt(High_Score_Key);
		
	}




	public static void SetHighestPitch(float pitch){
	
		PlayerPrefs.SetFloat(Highest_Pitch_Key,pitch);
	}
	
	public static float GetHighestPitch(){
	
		return PlayerPrefs.GetFloat(Highest_Pitch_Key);
	
	}
	
	public static void SetLowhestPitch(float pitch){
		
		PlayerPrefs.SetFloat(Lowest_Pitch_Key,pitch);
	}
	
	public static float GetLowhestPitch(){
		
		return PlayerPrefs.GetFloat(Lowest_Pitch_Key);
		
	}
	
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
