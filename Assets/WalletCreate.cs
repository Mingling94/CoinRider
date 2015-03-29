using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WalletCreate : MonoBehaviour {

	public InputField email;
	public InputField password;

	private string strEmail;
	private string strPassword;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}

	void SendMessage(string word){
	//	Application.LoadLevel (word);
		strEmail = email.text;
		strPassword = password.text;
		Debug.Log(strEmail);
		Debug.Log (strPassword);
	}

}
