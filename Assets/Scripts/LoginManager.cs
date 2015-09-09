using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Facebook;
using System.IO;
using GameSparks.Api.Requests;

public class LoginManager : MonoBehaviour {
	
	// Use this for initialization

	void Start (){
	


	}	


	public void CallToLogin () {
		//If facebook is not Initialized

		if (!FB.IsInitialized)
		{
			//Call FB.Init and once that's complete we'll call 
			//Facebook Login
			FB.Init(FacebookLogin);
		}
		//Otherwise if we already initialized call Facebook Login
		else
		{
			FacebookLogin();
		}
	}

	
	public void FacebookLogin()
	{
		//If we aren't logged in
		if (!FB.IsLoggedIn ) {
			//Call FB.Login, tell it to call GameSparksLogin
			//when done
			FB.Login ("", GameSparksLogin);

			}

	}



	









	//GameSparksLogin takes FBResult from FB.Login but we don't use it 
	//for anything
	public void GameSparksLogin(FBResult result) 
	{
		//It never hurts to double check it you are logged into Facebook                
		//before trying to log into GameSparks with Facebook
		if (FB.IsLoggedIn) {
			//This is the standard FacebookConnectRequest. This will                        
			//log into GameSparks with your Facebook Profile.

			new FacebookConnectRequest ().SetAccessToken (FB.AccessToken).Send ((response) =>
			{
				if (response.HasErrors) {
					Debug.Log ("Something failed with connecting with Facebook");
				} else {	
		
					//to the user that they are logged in...
				}
			});
		}
	}



}

