using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class loginAddress : MonoBehaviour {

	public InputField login;

	private string address;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

	void SendMessage(string word){
		Application.LoadLevel (word);
		address = login.text;
	}
}
